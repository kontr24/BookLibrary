using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Xml;

namespace BookLibrary
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string _fileLocation;


        private void MainForm_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
            cbAvailability.SelectedIndex = 0;
            cbCondition.SelectedIndex = 0;

            if (File.Exists(@"XML\LibraryXMLFile.xml")) // если существует данный файл
            {
                DataSet ds = new DataSet(); // создаем новый пустой кэш данных
                ds.ReadXml(@"XML\LibraryXMLFile.xml"); // записываем в него XML-данные из файла
                foreach (DataRow item in ds.Tables["Book"].Rows)
                {
                    int n = dgvMain.Rows.Add(); // добавляем новую сроку в dataGridView1
                    dgvMain.Rows[n].Cells[0].Value = item["Автор"]; // заносим в первый столбец созданной строки данные из первого столбца таблицы ds.
                    dgvMain.Rows[n].Cells[1].Value = item["Название"]; // то же самое со вторым столбцом
                    dgvMain.Rows[n].Cells[2].Value = item["Издательство"]; // то же самое с третьим столбцом
                    dgvMain.Rows[n].Cells[3].Value = item["Раздел"]; // то же самое с третьим столбцом
                    dgvMain.Rows[n].Cells[4].Value = item["Наличие"]; // то же самое с третьим столбцом
                    dgvMain.Rows[n].Cells[5].Value = item["Состояние"]; // то же самое с третьим столбцом

                }
                //dgvMain.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("XML файл не найден.", "Ошибка.");
            }
            dgvMain_CellClick(sender, new DataGridViewCellEventArgs(0, 0));

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAuthor.Text))
            {
                MessageBox.Show("Заполните поле 'Автор''.", "Ошибка.");
                return;
            }
            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                MessageBox.Show("Заполните поле 'Название''.", "Ошибка.");
                return;
            }
            if (string.IsNullOrEmpty(tbPublishingHouse.Text))
            {
                MessageBox.Show("Заполните поле 'Издательство''.", "Ошибка.");
                return;
            }
            if (string.IsNullOrEmpty(tbChapter.Text))
            {
                MessageBox.Show("Заполните поле 'Раздел''.", "Ошибка.");
                return;
            }

            else
            {
                int n = dgvMain.Rows.Add();
                dgvMain.Rows[n].Cells[0].Value = tbAuthor.Text;
                dgvMain.Rows[n].Cells[1].Value = tbTitle.Text;
                dgvMain.Rows[n].Cells[2].Value = tbPublishingHouse.Text;
                dgvMain.Rows[n].Cells[3].Value = tbChapter.Text;
                dgvMain.Rows[n].Cells[4].Value = cbAvailability.Text;
                dgvMain.Rows[n].Cells[5].Value = cbCondition.Text;
            }

            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Book";
                dt.Columns.Add("Автор");
                dt.Columns.Add("Название");
                dt.Columns.Add("Издательство");
                dt.Columns.Add("Раздел");
                dt.Columns.Add("Наличие");
                dt.Columns.Add("Состояние");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dgvMain.Rows)
                {
                    DataRow row = ds.Tables["Book"].NewRow();
                    row["Автор"] = r.Cells[0].Value;
                    row["Название"] = r.Cells[1].Value;
                    row["Издательство"] = r.Cells[2].Value;
                    row["Раздел"] = r.Cells[3].Value;
                    row["Наличие"] = r.Cells[4].Value;
                    row["Состояние"] = r.Cells[5].Value;

                    ds.Tables["Book"].Rows.Add(row);
                }
                if (_fileLocation == null)
                {
                    ds.WriteXml(@"XML\LibraryXMLFile.xml");
                }
                else
                {
                    ds.WriteXml(_fileLocation);
                }
                MessageBox.Show("Информация добавлена! XML файл успешно сохранен.", "Выполнено.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAuthor.Text))
            {
                MessageBox.Show("Заполните поле 'Автор''.", "Ошибка.");
                return;
            }
            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                MessageBox.Show("Заполните поле 'Название''.", "Ошибка.");
                return;
            }
            if (string.IsNullOrEmpty(tbPublishingHouse.Text))
            {
                MessageBox.Show("Заполните поле 'Издательство''.", "Ошибка.");
                return;
            }
            if (string.IsNullOrEmpty(tbChapter.Text))
            {
                MessageBox.Show("Заполните поле 'Раздел''.", "Ошибка.");
                return;
            }


            if (dgvMain.SelectedRows.Count > 0)
            {
                int n = dgvMain.SelectedRows[0].Index;
                dgvMain.Rows[n].Cells[0].Value = tbAuthor.Text;
                dgvMain.Rows[n].Cells[1].Value = tbTitle.Text;
                dgvMain.Rows[n].Cells[2].Value = tbPublishingHouse.Text;
                dgvMain.Rows[n].Cells[3].Value = tbChapter.Text;
                dgvMain.Rows[n].Cells[4].Value = cbAvailability.Text;
                dgvMain.Rows[n].Cells[5].Value = cbCondition.Text;


            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.", "Ошибка.");
            }

            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Book";
                dt.Columns.Add("Автор");
                dt.Columns.Add("Название");
                dt.Columns.Add("Издательство");
                dt.Columns.Add("Раздел");
                dt.Columns.Add("Наличие");
                dt.Columns.Add("Состояние");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dgvMain.Rows)
                {
                    DataRow row = ds.Tables["Book"].NewRow();
                    row["Автор"] = r.Cells[0].Value;
                    row["Название"] = r.Cells[1].Value;
                    row["Издательство"] = r.Cells[2].Value;
                    row["Раздел"] = r.Cells[3].Value;
                    row["Наличие"] = r.Cells[4].Value;
                    row["Состояние"] = r.Cells[5].Value;


                    ds.Tables["Book"].Rows.Add(row);
                }
                if (_fileLocation == null)
                {
                    ds.WriteXml(@"XML\LibraryXMLFile.xml");
                }
                else
                {
                    ds.WriteXml(_fileLocation);
                }
                MessageBox.Show("Информация обновлена! XML файл успешно сохранен.", "Выполнено.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.", "Ошибка.");
                return;
            }
                if (dgvMain.RowCount == 1)
            {
                MessageBox.Show("Нельзя удалить оставшуюся строку, так как будет изменена структура XML файла", "Ошибка");
                return;
            }
            var msgResult = MessageBox.Show("Вы действительно хотите удалить информацию о книге?", "Удаление строки", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (msgResult == DialogResult.OK)
            {
                if (dgvMain.SelectedRows.Count > 0)
                {
                    dgvMain.Rows.RemoveAt(dgvMain.SelectedRows[0].Index); //удаление
                }


                try
                {
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt.TableName = "Book";
                    dt.Columns.Add("Автор");
                    dt.Columns.Add("Название");
                    dt.Columns.Add("Издательство");
                    dt.Columns.Add("Раздел");
                    dt.Columns.Add("Наличие");
                    dt.Columns.Add("Состояние");
                    ds.Tables.Add(dt);

                    foreach (DataGridViewRow r in dgvMain.Rows)
                    {
                        DataRow row = ds.Tables["Book"].NewRow();
                        row["Автор"] = r.Cells[0].Value;
                        row["Название"] = r.Cells[1].Value;
                        row["Издательство"] = r.Cells[2].Value;
                        row["Раздел"] = r.Cells[3].Value;
                        row["Наличие"] = r.Cells[4].Value;
                        row["Состояние"] = r.Cells[5].Value;


                        ds.Tables["Book"].Rows.Add(row);
                    }
                    if (_fileLocation == null)
                    {
                        ds.WriteXml(@"XML\LibraryXMLFile.xml");
                    }
                    else
                    {
                        ds.WriteXml(_fileLocation);
                    }

                    MessageBox.Show("Информация о книге удалена! XML файл успешно сохранен.", "Выполнено.");
                }

                catch
                {
                    MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
                }
            }
        }



        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAuthor.Text = dgvMain.SelectedRows[0].Cells[0].Value.ToString();
            tbTitle.Text = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            tbPublishingHouse.Text = dgvMain.SelectedRows[0].Cells[2].Value.ToString();
            tbChapter.Text = dgvMain.SelectedRows[0].Cells[3].Value.ToString();
            cbAvailability.Text = dgvMain.SelectedRows[0].Cells[4].Value.ToString();
            cbCondition.Text = dgvMain.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            if (tbSearch.Text != "Поиск...")
            {
                for (int i = 0; i < dgvMain.Rows.Count; i++)
                {
                    if (cbSearch.SelectedIndex == 0)
                    {
                        dgvMain.Rows[i].Visible = dgvMain[0, i].Value.ToString().ToUpper().Contains(tbSearch.Text.ToUpper());
                    }
                    if (cbSearch.SelectedIndex == 1)
                    {
                        dgvMain.Rows[i].Visible = dgvMain[3, i].Value.ToString().ToUpper().Contains(tbSearch.Text.ToUpper());
                    }
                    if (cbSearch.SelectedIndex == 2)
                    {
                        dgvMain.Rows[i].Visible = dgvMain[4, i].Value.ToString().ToUpper().Contains(tbSearch.Text.ToUpper());
                    }

                }
                tbAuthor.Clear();

                tbTitle.Clear();
                tbPublishingHouse.Clear();
                tbChapter.Clear();

                dgvMain.ClearSelection();
            }


        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Поиск...")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.Black;

            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Поиск...";
                tbSearch.ForeColor = Color.Silver;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog load = new OpenFileDialog
            {
                Filter = @"XML (*.xml)|*.xml|Все файлы (*.*)|*.*",
                RestoreDirectory = true
            };

            if (load.ShowDialog() != DialogResult.OK) { return; }
            if (dgvMain.Rows.Count > 0)
            {
                dgvMain.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблица пустая.", "Ошибка.");
            }

            _fileLocation = load.FileName;

            if (File.Exists(load.FileName))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(load.FileName);
                foreach (DataRow item in ds.Tables["Book"].Rows)
                {

                    int n = dgvMain.Rows.Add();
                    dgvMain.Rows[n].Cells[0].Value = item["Автор"];
                    dgvMain.Rows[n].Cells[1].Value = item["Название"];
                    dgvMain.Rows[n].Cells[2].Value = item["Издательство"];
                    dgvMain.Rows[n].Cells[3].Value = item["Раздел"];
                    dgvMain.Rows[n].Cells[4].Value = item["Наличие"];
                    dgvMain.Rows[n].Cells[5].Value = item["Состояние"];

                }
                MessageBox.Show("XML файл успешно загружен.", "Выполнено.");
                //dgvMain.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("XML файл не найден.", "Ошибка.");
            }
            dgvMain_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = @"XML (*.xml)|*.xml|Все файлы (*.*)|*.*",

                RestoreDirectory = true
            };

            saveFile.FileName = "LibraryXMLFile.xml";


            if (saveFile.ShowDialog() != DialogResult.OK) { return; }


            _fileLocation = saveFile.FileName;

            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Book";
                dt.Columns.Add("Автор");
                dt.Columns.Add("Название");
                dt.Columns.Add("Издательство");
                dt.Columns.Add("Раздел");
                dt.Columns.Add("Наличие");
                dt.Columns.Add("Состояние");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dgvMain.Rows)
                {
                    DataRow row = ds.Tables["Book"].NewRow();
                    row["Автор"] = r.Cells[0].Value;
                    row["Название"] = r.Cells[1].Value;
                    row["Издательство"] = r.Cells[2].Value;
                    row["Раздел"] = r.Cells[3].Value;
                    row["Наличие"] = r.Cells[4].Value;
                    row["Состояние"] = r.Cells[5].Value;


                    ds.Tables["Book"].Rows.Add(row);
                }

                ds.WriteXml(_fileLocation);


                MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAuthor.Clear();

            tbTitle.Clear();
            tbPublishingHouse.Clear();
            tbChapter.Clear();

            dgvMain.ClearSelection();
        }
    }
}
