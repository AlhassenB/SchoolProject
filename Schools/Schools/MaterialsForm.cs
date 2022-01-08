using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Schools
{
    public partial class MaterialsForm : MetroFramework.Forms.MetroForm
    {
        public SchoolContext schoolContext = new SchoolContext();
        public List<Subject> listOfSubjects = new List<Subject>();
        public MaterialsForm()
        {
            InitializeComponent();
        }



        private void SelectColor_Click(object sender, EventArgs e)
        {
            PanelColor.ShowDialog();
            SelectColor.BackColor = PanelColor.Color;
            SelectColor.ForeColor = PanelColor.Color;
            // ColorString.Text = colorDialog1.Color.ToString();

            //When adding to database
            var colorBlue = PanelColor.Color;
            var hexBlue = ColorTranslator.ToHtml(colorBlue);
            ContainerColor.Text = hexBlue;
            //MessageBox.Show(hexBlue, "Color");
            //When importing color from database
            var myControlColor = ColorTranslator.FromHtml(hexBlue);
            ConvertedColor.Text = myControlColor.ToString();
            //MessageBox.Show(myControlColor.ToString(), "Color Name");
            //SelectColor.BackColor = myControlColor;
        }



        private void AddSubject_Click(object sender, EventArgs e)
        {
            if (CheckValueFieldsNonNull())
            {
                MessageBox.Show("الرجاء التثبت من إدخال كافة المعطيات");
            }
            else
            {
                Subject foundSubject = schoolContext.Subjects.FirstOrDefault(sub => sub.Code.Contains(CodeSubject.Text) && sub.Id > 0);

                if (foundSubject == null)
                {
                    DateTime date = PedagogicDate.Value;
                    Subject subject = new Subject
                    {
                        Code = CodeSubject.Text,
                        Description = NameSubject.Text,
                        SubjectClassName = SubjectClassName.Text,
                        Color = ContainerColor.Text,
                        ConvertedColor = ConvertedColor.Text,
                        PedagogicDate = Convert.ToDateTime(date.ToString("dddd, dd ,MM, yyyy", new CultureInfo("ar-TN"))),

                    };
                    schoolContext.Subjects.Add(subject);
                    schoolContext.SaveChanges();

                    SubjectList.DataSource = GetAllSubjects();
                    SetRowColor();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("هذه المادة توجد مسبقا");
                    SubjectList.DataSource = GetAllSubjects();
                    SetRowColor();
                    ClearFields();
                }
            }
        }

        private void UpdateSubject_Click(object sender, EventArgs e)
        {
            
            if (IdSubject.Text == "")
            {
                MessageBox.Show(" اختر المادة التي ترغب في تعديلها من خلال قائمة المواد");

            }
            else
            {
                Subject foundSubject = schoolContext.Subjects.FirstOrDefault(sub => sub.Id.ToString() == IdSubject.Text);
                if (foundSubject == null)
                {
                    MessageBox.Show(" اختر المادة التي ترغب في تعديلها من خلال قائمة المواد");
                    ClearFields();
                }
                else
                {

                    foundSubject.Code = CodeSubject.Text;
                    foundSubject.Description = NameSubject.Text;
                    foundSubject.SubjectClassName = SubjectClassName.Text;
                    foundSubject.Color = ContainerColor.Text;
                    foundSubject.ConvertedColor = ConvertedColor.Text;
                    foundSubject.PedagogicDate = PedagogicDate.Value;

                    schoolContext.SaveChanges();
                    SubjectList.DataSource = GetAllSubjects();
                    SetRowColor();
                    MessageBox.Show(" تم التعديل بنجاح");
                }
            }

        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            SubjectList.DataSource = GetAllSubjects();
            SetRowColor();
        }


        private void SubjectList_Click(object sender, EventArgs e)
        {
            DisplaySubjectDetails();

        }

        private void SubjectList_KeyDown(object sender, KeyEventArgs e)
        {
            SetRowColor();
            DisplaySubjectDetails();
        }

        private void SubjectList_KeyUp(object sender, KeyEventArgs e)
        {
            SetRowColor();
            DisplaySubjectDetails();
        }

        public void ClearFields()
        {
            IdSubject.Text = "";
            CodeSubject.Text = "";
            NameSubject.Text = "";
            SubjectClassName.Text = "";
            SelectColor.BackColor = Color.White;
            PedagogicDate.Value = Convert.ToDateTime(DateTime.Now.ToString("dddd, dd ,MM, yyyy", new CultureInfo("ar-TN")));
        }

        public bool CheckValueFieldsNonNull()
        {
            if (CodeSubject.Text == "" | NameSubject.Text == "" | SubjectClassName.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DisplaySubjectDetails()
        {
            Subject subject = new Subject() { };

            if (SubjectList.SelectedCells.Count > 0)
            {
                subject.Id=(Int32.Parse(SubjectList.SelectedCells[0].Value.ToString()));
                subject.Code = SubjectList.SelectedCells[1].Value.ToString();
                subject.Description = SubjectList.SelectedCells[2].Value.ToString();
                subject.SubjectClassName = SubjectList.SelectedCells[3].Value.ToString();
                subject.Color = SubjectList.SelectedCells[4].Value.ToString();
                subject.PedagogicDate = (DateTime)SubjectList.SelectedCells[6].Value;

                IdSubject.Text = subject.Id.ToString();
                CodeSubject.Text = subject.Code;
                NameSubject.Text = subject.Description;
                SubjectClassName.Text = subject.SubjectClassName;
                Color regColor = (Color)new ColorConverter().ConvertFromString((string)subject.Color);
                SelectColor.BackColor = regColor;
                ContainerColor.Text = subject.Color;
                PedagogicDate.Value = subject.PedagogicDate;
            }
        }

        public void SetRowColor()
        {
            for (int i = 0; i < SubjectList.RowCount; i++)
            {
                //Get the string color from datagrid 
                var result = SubjectList.Rows[i].Cells[4].Value;
                //Convert the string color to a Color 
                Color regColor = (Color)new ColorConverter().ConvertFromString((string)result);
                SubjectList.Rows[i].DefaultCellStyle.BackColor = regColor;
            }
        }

        public List<Subject> GetAllSubjects()
        {
            return listOfSubjects = schoolContext.Subjects.ToList();
        }

        private void DeleteSubject_Click(object sender, EventArgs e)
        {
            if (IdSubject.Text == "")
            {
                MessageBox.Show(" اختر المادة التي ترغب في تعديلها من خلال قائمة المواد");

            }
            else
            {
                Subject foundSubject = schoolContext.Subjects.FirstOrDefault(sub => sub.Id.ToString() == IdSubject.Text);
                if (foundSubject == null)
                {
                   MessageBox.Show(" اختر المادة التي ترغب في تعديلها من خلال قائمة المواد");
                    
                    ClearFields();
                }
                else
                {
                    schoolContext.Subjects.Remove(foundSubject);
                    schoolContext.SaveChanges();
                    MessageBox.Show(" تم حذف المادة بنجاح");
                    SubjectList.DataSource = GetAllSubjects();
                    SetRowColor();
                    ClearFields();

                }
            }
        }
    }
}
