using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using MySql.Data.MySqlClient;




namespace Excel_master
{
    public partial class Form1 : Form
    {
        string[] Main_combo;
        string[] TBG5 = new string[] { "TB090G5", "TB120G5", "TB160G5", "TB200G5", "TB240G5", "TB280G5", "TB380G5", "TB480G5", "TB580G5", "TB680G5", "TB880G5" };
        string[] DLG5 = new string[] { "DL450G5", "DL550G5", "DL650G5", "DL850G5", "DL1050G5", "DL1300G5", "DL1800G5", "DL2300G5", "DL2700G5", "DL3300G5" };
        string[] VHG5 = new string[] { "VH100RG5", "VH150RG5","VH200RG5"};
        string[] NCG5 = new string[] { "NC130G5", "NC220G5" };
        string[] DLA5 = new string[] { "DL450A5", "DL550A5", "DL650A5", "DL850A5", "DL1050A5", "DL1300A5", "DL1800A5", "DL2300A5", "DL2700A5", "DL3300A5" };
        string[] THA5 = new string[] { "TH100A5", "TH130A5", "TH160A5", "TH190A5", "TH240A5", "TH280A5", "TH380A5", "TH420A5", "TH480A5" };
        string[] VHARS = new string[] { "VHA50RS", "VHA75RS", "VHA100RS", "VHA120RS", "VHA150RS", "VHA200RS" };
        string[] VHLRS = new string[] { "VHL250RS", "VHL350RS", "VHL450RS"};
        string[] TEG5 = new string[] { "TE050G5", "TE110G5", "TE170G5", "TE220G5", "TE280G5", "TE350G5", "TE400G5", "TE280WG5" };
        string[] TEA5 = new string[] { "TE050A5", "TE110A5", "TE170A5", "TE220A5", "TE280A5", "TE350A5", "TE400A5", "TE450A5", "TE550A5", "TE650A5", "TE850A5" };
        string[] VHS = new string[] { "VH50S", "VH75S", "VH100S", "VH125S" };
        List<string[]> ary_category = new List<string[]>();
       
 
        
        
        string real_path;
        string path_convert;
        string load_path_convert;
        string cg_text;
        string machine_type;
        
          string _server = "localhost";
            int _port = 3306;
            string _database = "path"; //DB 이름
            string _id = "root"; //계정 아이디
            string _pw = "7788"; //계정 비밀번호
            string _connectionAddress = "";

            MySqlConnection mysql = new MySqlConnection();

                      

          
       

        public Form1()
        {
            InitializeComponent();
            Factory_Voltage.Text = "380";
            EXTconsent1.Text ="16";
            EXTconsent2.Text = "32";
            Main_2nd_volt.Text = "380";
            Motor_2nd_volt.Text = "380";
            SG_Phase_2nd_volt.Text = "220";
            Hotrun_2nd_volt.Text = "220";
            Hotrun_capacity.Text = "1500";
            Hotrun_N_use.SelectedIndex = 1;
            Main_trans_use.SelectedIndex = 1;
            Motor_trans_use.SelectedIndex = 1;
            SG_Phase_trans_use.SelectedIndex = 1;
            Hotrun_trans_use.SelectedIndex = 1;
            CG_Motor_use.SelectedIndex = 0;
            THA5_Motor_2_use.SelectedIndex = 1;
            Main_category.SelectedIndex = 0;
            Standard_text.TextChanged +=Standard_text_event;
            Pdf_convert.Checked = true;
            MySql_select("통합용량표");
            Load_path_label.Text = path_convert;
            ary_category.Add(TBG5);
            ary_category.Add(DLG5);
            ary_category.Add(VHG5);
            ary_category.Add(NCG5);
            ary_category.Add(DLA5);
            ary_category.Add(THA5);
            ary_category.Add(VHARS);
            ary_category.Add(VHLRS);
            ary_category.Add(TEG5);
            ary_category.Add(TEA5);
            DateTime dt = new DateTime();
            
           
            
        }



        public void Standard_text_event(object sender, EventArgs e)
        {
         
            if(Standard_text.Text.Contains(" ") && Standard_text.Text.Contains(")"))
            { 
            string[] result=Standard_text.Text.Split(' ');
               
            Injection_text.Text=result[0];
            string[] result_ton = result[1].Split(')');

            
                for(int i=0; i<ary_category.Count;i++)
                {
                    if (ary_category[i].Contains(result_ton[0].Substring(1)))
                    {
                        Main_category.SelectedIndex = i;
                        Ton_category.SelectedItem = result_ton[0].Substring(1);
                        break;
                    }
                }

                
            }
          
                


        }
        private void Create_btn_Click(object sender, EventArgs e)
        {
            
            if(Ton_category.Text=="" || Injection_text.Text =="" || path_label.Text=="" && Pdf_convert.Checked)
            {
                MessageBox.Show("기종 톤수선택, 폴더경로입력, 사출대를 입력하세요!", "용량표 생성 오류!");
            }
            else
            { 
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Workbook wb = app.Workbooks.Open(Filename: string.Format(@"{0}",Load_path_label.Text));
            Worksheet ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;


            ws.Cells[1, 4] = ERP_Number.Text + " " + Company_name.Text + " " + Ton_category.Text + " " + Injection_text.Text;

            ws.Cells[9, 46] = Main_category.Text; //AT9
            ws.Cells[9, 48] = Ton_category.Text; //AV9

            string text_int = Regex.Replace(Injection_text.Text, @"\D", ""); // 숫자만 꺼내오기
            double text_int_convert = Convert.ToDouble(text_int) / 100;
            string text_int_complete = string.Format("{0:0.0}", text_int_convert); // 소수첫째자리까지 



            string text_int_string = Regex.Replace(Injection_text.Text, text_int, "");
            ws.Cells[9, 50] = text_int_string + text_int_complete;
            

          
            ws.Cells[13, 55] = Factory_Voltage.Text; //BC13

            ws.Cells[7, 21] = EXTconsent1.Text; // U7
            ws.Cells[7, 23] = EXTconsent1_amount.Text; // W7

            ws.Cells[7, 25] = EXTconsent2.Text; // Y7
            ws.Cells[7, 27] = EXTconsent2_amount.Text; // AA7

            ws.Cells[30, 48] = Hotrunner.Text; //AV30
            ws.Cells[30, 49] = Hotrun_capacity.Text; //AW30
            ws.Cells[30, 52] = Hotrun_N_use.Text; //AZ30
            cg_text = CG_Motor_use.Text; //AV17
            ws.Range["AV17"].Value = cg_text;
            ws.Cells[17, 48] = ws.Cells[17, 48];
            ws.Cells[28, 49] = THA5_Motor_2_use.Text; // AW28

            if (Motor_trans_use.Text == "적용")
            {
                ws.Cells[12, 48] = "모터트랜스";
                ws.Cells[12, 50] = Motor_1st_volt.Text;
                ws.Cells[12, 52] = Motor_2nd_volt.Text;
            }
            else
            {
                ws.Cells[12, 48] = "사용안함";
            }
            if(Main_trans_use.Text=="적용")
            {
                ws.Cells[12, 48] = "메인트랜스";
                ws.Cells[12, 50] = Main_1st_volt.Text;
                ws.Cells[12, 52] = Main_2nd_volt.Text;
            }
            else
            {
                ws.Cells[12, 48] = "사용안함";
            }
           
                ws.Cells[35, 48] = SG_Phase_trans_use.Text;
                ws.Cells[35, 50] = SG_Phase_1st_volt.Text;
                ws.Cells[35, 52] = SG_Phase_2nd_volt.Text;
            
           
          

                ws.Cells[33, 48] = Hotrun_trans_use.Text;
                ws.Cells[33, 50] = Hotrun_1st_volt.Text;
                ws.Cells[33, 52] = Hotrun_2nd_volt.Text;
         
            //--------------------------------------------------------------- cell 정보 insert
            if(Main_category.Text=="NCG5")
            {
                ws.Range["A50", "A50"].EntireRow.Hidden = false;
                ws.Range["A66", "A76"].EntireRow.Hidden = false;
                ws.Range["A70", "A71"].EntireRow.Hidden = true;
            }
            else
            {
                ws.Range["A50", "A50"].EntireRow.Hidden = true;
                ws.Range["A66", "A76"].EntireRow.Hidden = true;
            }

            if (Main_category.Text == "THA5" || Main_category.Text == "VHARS" || Main_category.Text == "VHLRS" || Main_category.Text == "TEA5" || Main_category.Text == "TEG5" || Main_category.Text == "VHG5" || Main_category.Text == "VHS")
            {
                ws.Range["A57", "A58"].EntireRow.Hidden = true;
                ws.Range["A59", "A60"].EntireRow.Hidden = false;
                
            }
            else
            {
                ws.Range["A57", "A58"].EntireRow.Hidden = false;
                ws.Range["A59", "A60"].EntireRow.Hidden = true;
            }

            if(Main_category.Text=="DLA5" || Ton_category.Text=="TH480A5")
            {
                ws.Range["A107", "A115"].EntireRow.Hidden = false;
            }
            else
            {
                ws.Range["A107", "A115"].EntireRow.Hidden = true;
                
            }
            if (Main_category.Text == "THA5" || Main_category.Text == "VHARS" || Main_category.Text == "VHLRS")
            {
               if(Ton_category.Text!="TH480A5")
               { 
                ws.Range["A100", "A106"].EntireRow.Hidden = false;
               }
            }
            else 
            {
                ws.Range["A100", "A106"].EntireRow.Hidden = true;
            }
            if(CG_Motor_use.SelectedIndex==0)
            {
                ws.Range["A92", "A97"].EntireRow.Hidden = true;
                ws.Range["I15"].Value = ws.Range["BU25"].Value;
            }
            else
            {
                ws.Range["A92", "A97"].EntireRow.Hidden = false;

                ws.Range["I15"].Value = ws.Range["BU27"].Value;

            }

            if (Main_category.Text == "VHARS" || Main_category.Text == "VHLRS")
            {
                ws.Range["I15"].Value = ws.Range["BU29"].Value;
            }

            if (Main_category.Text == "TEA5" || Main_category.Text == "TEG5")
            {
                ws.Range["A117", "A127"].EntireRow.Hidden = false;
            }

            else
            {
                ws.Range["A117", "A127"].EntireRow.Hidden = true;
            }
            


            //--------------------------------------------------------------- 시트행 숨기기 관련 코드


            //Filename: @"\\172.16.100.20\06_01_연구소_도면\전기도면\3. 최신 전기도면\e.xlsm"

            wb.SaveAs(Filename: String.Format(@"{0}\{1}_{2}_{3}_용량표.xlsm", Save_path_label.Text, ERP_Number.Text, Ton_category.Text, Company_name.Text));

            if (Pdf_convert.Checked)
            {
                wb.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, String.Format(@"{0}\{1}_{2}_{3}_용량표", Save_path_label.Text, ERP_Number.Text, Ton_category.Text, Company_name.Text),false,false,false,1,1);


                File.Copy(String.Format(@"{0}\{1}_{2}_{3}_용량표.pdf", Save_path_label.Text, ERP_Number.Text, Ton_category.Text, Company_name.Text), String.Format(@"\\172.16.100.20\06_01_연구소_도면\전기도면\6.수주별\{5}년\{4}\{0}\{1}_{2}_{3}_용량표.pdf", real_path, ERP_Number.Text, Ton_category.Text, Company_name.Text,machine_type,DateTime.Now.ToString("yyyy")));

                    wb.Close();                
            }
            
            //File.Delete("D:e.xlsm");
            //wb.SaveAs(Filename: String.Format(@"\\172.16.100.20\06_01_연구소_도면\00 출도일자별도면\{0}\02_전기도면\용량표\{1}_{2}_{3}_용량표.xlsm", real_path, Ton_category.Text, Injection_text.Text, Company_name.Text));
               
            }
        }

        private void Main_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ton_category.Items.Clear();
            switch (Main_category.SelectedIndex)
            {
                case 0:
                    Main_combo = TBG5;
                    machine_type = "TB-G5";
                    break;
                case 1:
                    Main_combo = DLG5;
                    machine_type = "DL-G5";
                    break;
                case 2:
                    Main_combo = VHG5;
                    machine_type = "VH-G5";
                    break;
                case 3:
                    Main_combo = NCG5;
                    machine_type = "NC-G5";
                    break;
                case 4:
                    Main_combo = DLA5;
                    machine_type = "DL-A5";
                    break;
                case 5:
                    Main_combo = THA5;
                    machine_type = "TH-A5";
                    break;
                case 6:
                    Main_combo = VHARS;
                    machine_type = "VHA(L)";
                    break;
                case 7:
                    Main_combo = VHLRS;
                    machine_type = "VHA(L)";
                    break;
                case 8:
                    Main_combo = TEG5;
                    machine_type = "TE-G5(NC)";
                    break;
                case 9:
                    Main_combo = TEA5;
                    machine_type = "TE-A5";
                    break;
                case 10:
                    Main_combo = VHS;
                    machine_type = "VHA(L)";
                    break;
            }
           Ton_category.Items.AddRange(Main_combo);


           MySql_select(Main_category.Text);
           Save_path_label.Text = path_convert; 
        
        }

        private void folder_crt_btn_Click(object sender, EventArgs e)
        {
            if(Company_name.Text=="" ||  ERP_Number.Text=="" || Machine_1.Text=="")
            {
                MessageBox.Show("수주번호, 회사이름, 기종을 입력하세요!","폴더 생성 오류!");
                
            }
            else
            { 
            String Machine_1_text;
            String Machine_2_text;
            String Machine_3_text;
            if(Machine_2.Text=="")
            {
             Machine_1_text = Machine_1.Text;
            }
            else
            {
             Machine_1_text = Machine_1.Text+",";
            }
            if (Machine_3.Text == "")
            {
                Machine_2_text = Machine_2.Text;
            }
            else
            {
                Machine_2_text = Machine_2.Text + ",";
            }
            if (Machine_4.Text == "")
            {
                Machine_3_text = Machine_3.Text;
            }
            else
            {
                Machine_3_text = Machine_3.Text + ",";
            }
            
            String Machine = Machine_1_text+ Machine_2_text+ Machine_3_text+ Machine_4.Text;
            real_path = ERP_Number.Text + "_" + Machine + "_" + Company_name.Text;
            DirectoryInfo path = new DirectoryInfo(String.Format("\\\\172.16.100.20\\06_01_연구소_도면\\전기도면\\6.수주별\\{5}년\\{4}\\{1}_{2}_{3}", real_path, ERP_Number.Text, Machine, Company_name.Text, machine_type, DateTime.Now.ToString("yyyy")));
            path_label.Text = String.Format("\\\\172.16.100.20\\06_01_연구소_도면\\전기도면\\6.수주별\\{5}년\\{4}\\{1}_{2}_{3}", real_path, ERP_Number.Text, Machine, Company_name.Text, machine_type, DateTime.Now.ToString("yyyy"));
            
            if(!path.Exists)
            {
                path.Create();
              /*  DirectoryInfo path_01 = new DirectoryInfo(path.FullName+"\\01_기계도면");
                DirectoryInfo path_02 = new DirectoryInfo(path.FullName+"\\02_전기도면");
                DirectoryInfo path_03 = new DirectoryInfo(path.FullName+"\\03_검사성적서");
                DirectoryInfo path_04 = new DirectoryInfo(path.FullName+"\\04_고객전달매뉴얼");
                DirectoryInfo path_05 = new DirectoryInfo(path.FullName+"\\05_고객전달인증서");
                DirectoryInfo path_06 = new DirectoryInfo(path.FullName+"\\06_고객전달도면");
                DirectoryInfo path_07 = new DirectoryInfo(path.FullName+"\\02_전기도면\\용량표");
                path_01.Create();
                path_02.Create();
                path_03.Create();
                path_04.Create();
                path_05.Create();
                path_06.Create();
                path_07.Create();*/
                
            }
            
            Process.Start(path.FullName);

            }

            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_path = new FolderBrowserDialog();
            if(folder_path.ShowDialog() == DialogResult.OK)
            {
                path_convert = folder_path.SelectedPath;

                Save_path_label.Text = path_convert;
                path_convert = path_convert.Replace("\\", "#");
            }
            MySql_update(Main_category.Text);
        }


        private void MySql_update(string ob)
        {

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.
                    string updateQuery = string.Format("UPDATE path_imfo SET {0} = '{1}' WHERE ID =1",ob,path_convert);

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");




                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void MySql_select(string ob)
        {

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.
                    string SelectQuery = string.Format("Select * from path_imfo where ID = 1");

                    
                    MySqlCommand command = new MySqlCommand(SelectQuery, mysql);
                   

                    MySqlDataReader table = command.ExecuteReader();
                    while(table.Read())
                    { 
                    path_convert = table[string.Format("{0}", ob)] as string;
                    }
                    path_convert = path_convert.Replace("#", "\\");
                                   
                    

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_capacity_excel = new OpenFileDialog();
            load_capacity_excel.InitialDirectory = "C:\\";
            if(load_capacity_excel.ShowDialog() == DialogResult.OK)
            {
                path_convert = load_capacity_excel.FileName;
                Load_path_label.Text = path_convert;
                path_convert = path_convert.Replace("\\", "#");
                MySql_update("통합용량표");
                load_path_convert = path_convert;
            }
           

        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            Factory_Voltage.Text = "380";
            Standard_text.Text = "";
            Injection_text.Text = "";
            EXTconsent1_amount.Text = "";
            EXTconsent2_amount.Text = "";
            ERP_Number.Text = "";
            Company_name.Text = "";
            Machine_1.Text = "";
            Machine_2.Text = "";
            Machine_3.Text = "";
            Machine_4.Text = "";
            Hotrunner.Text = "";
            Hotrun_capacity.Text = "1500";
            Hotrun_1st_volt.Text = "";
            Hotrun_2nd_volt.Text = "220";
            Main_1st_volt.Text = "";
            Main_2nd_volt.Text = "380";
            Motor_1st_volt.Text = "";
            Motor_2nd_volt.Text ="380";
            SG_Phase_1st_volt.Text = "";
            SG_Phase_2nd_volt.Text = "220";
            



        }   

       

     
       

  
    

       

     

        

     

      

       

     

       

      

     
        



       
    }
            
}
