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
using ClassLibrary;
using Microsoft.VisualBasic;

namespace LR3
{
    public partial class MainForm : Form
    {
        /*
          •	В рамках любого варианта предусмотреть масштабирование элементов интерфейса по размерам формы
          •	Добавить проверки на корректный ввод пользователя
          •	Предусмотреть все подписи, заголовки окон и подсказки к разделам
          •	Обращайте внимание на именование объектов !!! 
          •	Не создавайте неиспользуемых обработчиков событий !!!
        Вариант 4.
        Предприятие X производит отпуск лекарственных препаратов по рецептам.
        Набор лекарственных средств в рамках одной номенклатурной группы строго определён.
        Представить в программе Win Forms возможность выбора номенклатурных групп для заказа (компонент списка),
        а также выбор заказываемых лекарственных препаратов выбранной группы с помощью компонента ComboBox.
        При выборе препарата отображается его карточка с изображением и подробным описанием о стоимости средства,
        производителе, сроке годности и поставщике.
        Для каждого выбранного компонента можно указать количество заказываемого.
        По нажатию на кнопку «Заказать» формируется вывод текста на форму с перечнем номенклатурных групп и
        количеством заказываемых препаратов для каждой группы.
         */
        /*
         Загрузка с файла
         Докум с описание тест кейсов, разработка авто тестов, отчет .
         */
        Dictionary<string, List<Medicine>> medicineGroupList = new Dictionary<string, List<Medicine>>();
        public MainForm()
        {
            InitializeComponent();
            {
                string path = "../../../Import/Imp";
                Import imp = new Import();
                medicineGroupList = imp.ImportFromTxt(path);
                GroupListBox.DataSource = medicineGroupList.Keys.ToList();
            }
            {
                string path = Path.Combine(Application.StartupPath, "Image", "../../Images/Ambroxol.jpg");
                List<Medicine> inputList = new List<Medicine>();
                inputList.Add(new Medicine("Амброксол", Path.Combine(Application.StartupPath, "Image", "Ambroxol.jpg"),
                                                      47, "ООО Амброксол", "ООО Амброксол",
                                                      "15 недель", "Лекарство от кашля (таблетки)"));
                inputList.Add(new Medicine("Коделак", Path.Combine(Application.StartupPath, "Image", "Kodelak.jpg"),
                                                    32, "ООО Коделак", "ООО Коделак",
                                                    "4 недели", "Лекарство от кашля (сироп)"));
                medicineGroupList.Add("Лекарства от кашля", inputList);
                List<Medicine> inputList2 = new List<Medicine>();
                inputList2.Add(new Medicine("Терафлю", Path.Combine(Application.StartupPath, "Image", "Teraflu.jpg"),
                                                     68, "ООО Терафлю", "ООО Терафлю",
                                                     "2 недели", "Жаропонижающее (пакетики)"));
                inputList2.Add(new Medicine("Nurofen", Path.Combine(Application.StartupPath, "Image", "Nurofen.jpg"),
                                                     89, "ООО Nurofen", "ООО Nurofen",
                                                     "15 недель", "Жаропонижающее (таблетки)"));
                medicineGroupList.Add("Жаропонижающие", inputList2);
                GroupListBox.DataSource = medicineGroupList.Keys.ToList();
            }
        }

        private void GroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Medicine> medicines = medicineGroupList[GroupListBox.SelectedItem.ToString()].ToList();
            List<string> inputList = medicines.Select(m => m.Name).ToList();
            MedicineComboBox.DataSource = inputList;
        }
        //jljljljljljljljljljljljljljljljljljljljljlj
        private void MedicineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Medicine> medicines = medicineGroupList[GroupListBox.SelectedItem.ToString()].ToList();
            Medicine med = medicines[MedicineComboBox.SelectedIndex];

            MedicineTextBox.Text = "Название: " + med.Name + ";";
            MedicineTextBox.AppendText(Environment.NewLine + "Цена: " + med.Cost + ";");
            MedicineTextBox.AppendText(Environment.NewLine + "Производитель: " + med.Manufacturer + ";");
            MedicineTextBox.AppendText(Environment.NewLine + "Поставщик: " + med.Supplier + ";");
            MedicineTextBox.AppendText(Environment.NewLine + "Срок годности: " + med.ExpirationDate + ";");
            MedicineTextBox.AppendText(Environment.NewLine + "Описание: " + med.Description + ".");

            MainPictureBox.ImageLocation = med.Image;
        }
        //jljljljljljljljljljljljljljljljljljljljljlj
        private void OrderButton_Click(object sender, EventArgs e)
        {
            string order = ((Interaction.InputBox("Сколько лекарства вы хотите заказать?", "Заказ")) + " " + MedicineComboBox.Text);
            string result = (OrderTextBox.Text + order+"; ");
            OrderTextBox.Text = result;
        }
    }
}
