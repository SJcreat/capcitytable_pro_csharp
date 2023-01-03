namespace Excel_master
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.Main_category = new System.Windows.Forms.ComboBox();
            this.Ton_category = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Injection_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EXTconsent1 = new System.Windows.Forms.TextBox();
            this.EXTconsent1_amount = new System.Windows.Forms.TextBox();
            this.EXTconsent2 = new System.Windows.Forms.TextBox();
            this.EXTconsent2_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Hotrunner = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Factory_Voltage = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label9 = new System.Windows.Forms.Label();
            this.Standard_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Company_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ERP_Number = new System.Windows.Forms.TextBox();
            this.folder_crt_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Machine_1 = new System.Windows.Forms.TextBox();
            this.Machine_2 = new System.Windows.Forms.TextBox();
            this.Machine_3 = new System.Windows.Forms.TextBox();
            this.Machine_4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Main_trans_use = new System.Windows.Forms.ComboBox();
            this.Motor_trans_use = new System.Windows.Forms.ComboBox();
            this.SG_Phase_trans_use = new System.Windows.Forms.ComboBox();
            this.Hotrun_trans_use = new System.Windows.Forms.ComboBox();
            this.Main_1st_volt = new System.Windows.Forms.TextBox();
            this.Main_2nd_volt = new System.Windows.Forms.TextBox();
            this.Motor_1st_volt = new System.Windows.Forms.TextBox();
            this.Motor_2nd_volt = new System.Windows.Forms.TextBox();
            this.SG_Phase_1st_volt = new System.Windows.Forms.TextBox();
            this.SG_Phase_2nd_volt = new System.Windows.Forms.TextBox();
            this.Hotrun_1st_volt = new System.Windows.Forms.TextBox();
            this.Hotrun_2nd_volt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Hotrun_capacity = new System.Windows.Forms.TextBox();
            this.Hotrun_N_use = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.THA5_Motor_2_use = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.CG_Motor_use = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pdf_convert = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.path_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Save_path_label = new System.Windows.Forms.Label();
            this.Load_button = new System.Windows.Forms.Button();
            this.Load_path_label = new System.Windows.Forms.Label();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.TE_express = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_Btn
            // 
            this.Create_Btn.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Create_Btn.Location = new System.Drawing.Point(685, 261);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(104, 64);
            this.Create_Btn.TabIndex = 0;
            this.Create_Btn.Text = "용량표  생성";
            this.Create_Btn.UseVisualStyleBackColor = true;
            this.Create_Btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Main_category
            // 
            this.Main_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Main_category.FormattingEnabled = true;
            this.Main_category.Items.AddRange(new object[] {
            "TBG5",
            "DLG5",
            "VHG5",
            "NCG5",
            "DLA5",
            "THA5",
            "VHARS",
            "VHLRS",
            "TEG5",
            "TEA5",
            "VHS"});
            this.Main_category.Location = new System.Drawing.Point(148, 87);
            this.Main_category.Name = "Main_category";
            this.Main_category.Size = new System.Drawing.Size(100, 20);
            this.Main_category.TabIndex = 1;
            this.Main_category.SelectedIndexChanged += new System.EventHandler(this.Main_category_SelectedIndexChanged);
            // 
            // Ton_category
            // 
            this.Ton_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ton_category.FormattingEnabled = true;
            this.Ton_category.Location = new System.Drawing.Point(279, 87);
            this.Ton_category.Name = "Ton_category";
            this.Ton_category.Size = new System.Drawing.Size(100, 20);
            this.Ton_category.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.Location = new System.Drawing.Point(179, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 18);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "기종";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(312, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "톤수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(433, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "사출대";
            // 
            // Injection_text
            // 
            this.Injection_text.Location = new System.Drawing.Point(407, 87);
            this.Injection_text.Name = "Injection_text";
            this.Injection_text.Size = new System.Drawing.Size(100, 21);
            this.Injection_text.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(557, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "외부콘센트";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(691, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "갯수";
            // 
            // EXTconsent1
            // 
            this.EXTconsent1.Location = new System.Drawing.Point(548, 59);
            this.EXTconsent1.Name = "EXTconsent1";
            this.EXTconsent1.Size = new System.Drawing.Size(100, 21);
            this.EXTconsent1.TabIndex = 3;
            // 
            // EXTconsent1_amount
            // 
            this.EXTconsent1_amount.Location = new System.Drawing.Point(669, 59);
            this.EXTconsent1_amount.Name = "EXTconsent1_amount";
            this.EXTconsent1_amount.Size = new System.Drawing.Size(100, 21);
            this.EXTconsent1_amount.TabIndex = 3;
            // 
            // EXTconsent2
            // 
            this.EXTconsent2.Location = new System.Drawing.Point(548, 86);
            this.EXTconsent2.Name = "EXTconsent2";
            this.EXTconsent2.Size = new System.Drawing.Size(100, 21);
            this.EXTconsent2.TabIndex = 3;
            // 
            // EXTconsent2_amount
            // 
            this.EXTconsent2_amount.Location = new System.Drawing.Point(669, 86);
            this.EXTconsent2_amount.Name = "EXTconsent2_amount";
            this.EXTconsent2_amount.Size = new System.Drawing.Size(100, 21);
            this.EXTconsent2_amount.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(995, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "하트러너";
            // 
            // Hotrunner
            // 
            this.Hotrunner.Location = new System.Drawing.Point(972, 187);
            this.Hotrunner.Name = "Hotrunner";
            this.Hotrunner.Size = new System.Drawing.Size(100, 21);
            this.Hotrunner.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(40, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "공장전압";
            // 
            // Factory_Voltage
            // 
            this.Factory_Voltage.Location = new System.Drawing.Point(21, 86);
            this.Factory_Voltage.Name = "Factory_Voltage";
            this.Factory_Voltage.Size = new System.Drawing.Size(100, 21);
            this.Factory_Voltage.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(374, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "규격";
            // 
            // Standard_text
            // 
            this.Standard_text.Location = new System.Drawing.Point(279, 30);
            this.Standard_text.Name = "Standard_text";
            this.Standard_text.Size = new System.Drawing.Size(228, 21);
            this.Standard_text.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(352, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "회사이름";
            // 
            // Company_name
            // 
            this.Company_name.Location = new System.Drawing.Point(279, 221);
            this.Company_name.Name = "Company_name";
            this.Company_name.Size = new System.Drawing.Size(227, 21);
            this.Company_name.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(352, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "수주번호";
            // 
            // ERP_Number
            // 
            this.ERP_Number.Location = new System.Drawing.Point(279, 166);
            this.ERP_Number.Name = "ERP_Number";
            this.ERP_Number.Size = new System.Drawing.Size(227, 21);
            this.ERP_Number.TabIndex = 3;
            // 
            // folder_crt_btn
            // 
            this.folder_crt_btn.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.folder_crt_btn.Location = new System.Drawing.Point(685, 176);
            this.folder_crt_btn.Name = "folder_crt_btn";
            this.folder_crt_btn.Size = new System.Drawing.Size(104, 64);
            this.folder_crt_btn.TabIndex = 0;
            this.folder_crt_btn.Text = "폴더 생성";
            this.folder_crt_btn.UseVisualStyleBackColor = true;
            this.folder_crt_btn.Click += new System.EventHandler(this.folder_crt_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(368, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "기종";
            // 
            // Machine_1
            // 
            this.Machine_1.Location = new System.Drawing.Point(279, 282);
            this.Machine_1.Name = "Machine_1";
            this.Machine_1.Size = new System.Drawing.Size(100, 21);
            this.Machine_1.TabIndex = 3;
            // 
            // Machine_2
            // 
            this.Machine_2.Location = new System.Drawing.Point(409, 282);
            this.Machine_2.Name = "Machine_2";
            this.Machine_2.Size = new System.Drawing.Size(97, 21);
            this.Machine_2.TabIndex = 3;
            // 
            // Machine_3
            // 
            this.Machine_3.Location = new System.Drawing.Point(279, 314);
            this.Machine_3.Name = "Machine_3";
            this.Machine_3.Size = new System.Drawing.Size(100, 21);
            this.Machine_3.TabIndex = 3;
            // 
            // Machine_4
            // 
            this.Machine_4.Location = new System.Drawing.Point(409, 314);
            this.Machine_4.Name = "Machine_4";
            this.Machine_4.Size = new System.Drawing.Size(97, 21);
            this.Machine_4.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(968, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "*옵션";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(969, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "메인트랜스";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(969, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "모터트랜스";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(969, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 18);
            this.label17.TabIndex = 2;
            this.label17.Text = "단상트랜스";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(969, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "하트러너 트랜스";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1124, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "사용";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(1232, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 18);
            this.label19.TabIndex = 2;
            this.label19.Text = "1차 전압";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(1354, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 18);
            this.label20.TabIndex = 2;
            this.label20.Text = "2차 전압";
            // 
            // Main_trans_use
            // 
            this.Main_trans_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Main_trans_use.FormattingEnabled = true;
            this.Main_trans_use.Items.AddRange(new object[] {
            "적용",
            "미적용"});
            this.Main_trans_use.Location = new System.Drawing.Point(1104, 40);
            this.Main_trans_use.Name = "Main_trans_use";
            this.Main_trans_use.Size = new System.Drawing.Size(86, 20);
            this.Main_trans_use.TabIndex = 1;
            // 
            // Motor_trans_use
            // 
            this.Motor_trans_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Motor_trans_use.FormattingEnabled = true;
            this.Motor_trans_use.Items.AddRange(new object[] {
            "적용",
            "미적용"});
            this.Motor_trans_use.Location = new System.Drawing.Point(1104, 69);
            this.Motor_trans_use.Name = "Motor_trans_use";
            this.Motor_trans_use.Size = new System.Drawing.Size(86, 20);
            this.Motor_trans_use.TabIndex = 1;
            // 
            // SG_Phase_trans_use
            // 
            this.SG_Phase_trans_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SG_Phase_trans_use.FormattingEnabled = true;
            this.SG_Phase_trans_use.Items.AddRange(new object[] {
            "적용",
            "미적용"});
            this.SG_Phase_trans_use.Location = new System.Drawing.Point(1104, 100);
            this.SG_Phase_trans_use.Name = "SG_Phase_trans_use";
            this.SG_Phase_trans_use.Size = new System.Drawing.Size(86, 20);
            this.SG_Phase_trans_use.TabIndex = 1;
            // 
            // Hotrun_trans_use
            // 
            this.Hotrun_trans_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hotrun_trans_use.FormattingEnabled = true;
            this.Hotrun_trans_use.Items.AddRange(new object[] {
            "적용",
            "미적용"});
            this.Hotrun_trans_use.Location = new System.Drawing.Point(1104, 130);
            this.Hotrun_trans_use.Name = "Hotrun_trans_use";
            this.Hotrun_trans_use.Size = new System.Drawing.Size(86, 20);
            this.Hotrun_trans_use.TabIndex = 1;
            // 
            // Main_1st_volt
            // 
            this.Main_1st_volt.Location = new System.Drawing.Point(1226, 39);
            this.Main_1st_volt.Name = "Main_1st_volt";
            this.Main_1st_volt.Size = new System.Drawing.Size(76, 21);
            this.Main_1st_volt.TabIndex = 3;
            // 
            // Main_2nd_volt
            // 
            this.Main_2nd_volt.Location = new System.Drawing.Point(1348, 39);
            this.Main_2nd_volt.Name = "Main_2nd_volt";
            this.Main_2nd_volt.Size = new System.Drawing.Size(76, 21);
            this.Main_2nd_volt.TabIndex = 3;
            // 
            // Motor_1st_volt
            // 
            this.Motor_1st_volt.Location = new System.Drawing.Point(1226, 69);
            this.Motor_1st_volt.Name = "Motor_1st_volt";
            this.Motor_1st_volt.Size = new System.Drawing.Size(76, 21);
            this.Motor_1st_volt.TabIndex = 3;
            // 
            // Motor_2nd_volt
            // 
            this.Motor_2nd_volt.Location = new System.Drawing.Point(1348, 69);
            this.Motor_2nd_volt.Name = "Motor_2nd_volt";
            this.Motor_2nd_volt.Size = new System.Drawing.Size(76, 21);
            this.Motor_2nd_volt.TabIndex = 3;
            // 
            // SG_Phase_1st_volt
            // 
            this.SG_Phase_1st_volt.Location = new System.Drawing.Point(1226, 99);
            this.SG_Phase_1st_volt.Name = "SG_Phase_1st_volt";
            this.SG_Phase_1st_volt.Size = new System.Drawing.Size(76, 21);
            this.SG_Phase_1st_volt.TabIndex = 3;
            // 
            // SG_Phase_2nd_volt
            // 
            this.SG_Phase_2nd_volt.Location = new System.Drawing.Point(1348, 99);
            this.SG_Phase_2nd_volt.Name = "SG_Phase_2nd_volt";
            this.SG_Phase_2nd_volt.Size = new System.Drawing.Size(76, 21);
            this.SG_Phase_2nd_volt.TabIndex = 3;
            // 
            // Hotrun_1st_volt
            // 
            this.Hotrun_1st_volt.Location = new System.Drawing.Point(1226, 129);
            this.Hotrun_1st_volt.Name = "Hotrun_1st_volt";
            this.Hotrun_1st_volt.Size = new System.Drawing.Size(76, 21);
            this.Hotrun_1st_volt.TabIndex = 3;
            // 
            // Hotrun_2nd_volt
            // 
            this.Hotrun_2nd_volt.Location = new System.Drawing.Point(1348, 129);
            this.Hotrun_2nd_volt.Name = "Hotrun_2nd_volt";
            this.Hotrun_2nd_volt.Size = new System.Drawing.Size(76, 21);
            this.Hotrun_2nd_volt.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(1096, 166);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 18);
            this.label21.TabIndex = 2;
            this.label21.Text = "1존당 용량";
            // 
            // Hotrun_capacity
            // 
            this.Hotrun_capacity.Location = new System.Drawing.Point(1089, 187);
            this.Hotrun_capacity.Name = "Hotrun_capacity";
            this.Hotrun_capacity.Size = new System.Drawing.Size(100, 21);
            this.Hotrun_capacity.TabIndex = 3;
            // 
            // Hotrun_N_use
            // 
            this.Hotrun_N_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hotrun_N_use.FormattingEnabled = true;
            this.Hotrun_N_use.Items.AddRange(new object[] {
            "미적용",
            "적용"});
            this.Hotrun_N_use.Location = new System.Drawing.Point(1207, 188);
            this.Hotrun_N_use.Name = "Hotrun_N_use";
            this.Hotrun_N_use.Size = new System.Drawing.Size(86, 20);
            this.Hotrun_N_use.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(1221, 167);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 18);
            this.label22.TabIndex = 2;
            this.label22.Text = "N상 사용";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(983, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 18);
            this.label23.TabIndex = 2;
            this.label23.Text = "계량전동기";
            // 
            // THA5_Motor_2_use
            // 
            this.THA5_Motor_2_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.THA5_Motor_2_use.FormattingEnabled = true;
            this.THA5_Motor_2_use.Items.AddRange(new object[] {
            "적용",
            "미적용"});
            this.THA5_Motor_2_use.Location = new System.Drawing.Point(1089, 259);
            this.THA5_Motor_2_use.Name = "THA5_Motor_2_use";
            this.THA5_Motor_2_use.Size = new System.Drawing.Size(100, 20);
            this.THA5_Motor_2_use.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(1092, 224);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 18);
            this.label24.TabIndex = 2;
            this.label24.Text = "THA5 모터2";
            // 
            // CG_Motor_use
            // 
            this.CG_Motor_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CG_Motor_use.FormattingEnabled = true;
            this.CG_Motor_use.Items.AddRange(new object[] {
            "사용안함",
            "45",
            "55",
            "75",
            "90",
            "110",
            "132",
            "160",
            "200",
            "250",
            "315",
            "355",
            "400",
            "450",
            "500"});
            this.CG_Motor_use.Location = new System.Drawing.Point(972, 259);
            this.CG_Motor_use.Name = "CG_Motor_use";
            this.CG_Motor_use.Size = new System.Drawing.Size(100, 20);
            this.CG_Motor_use.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Pdf_convert
            // 
            this.Pdf_convert.AutoSize = true;
            this.Pdf_convert.Location = new System.Drawing.Point(814, 308);
            this.Pdf_convert.Name = "Pdf_convert";
            this.Pdf_convert.Size = new System.Drawing.Size(71, 16);
            this.Pdf_convert.TabIndex = 4;
            this.Pdf_convert.Text = "PDF생성";
            this.Pdf_convert.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(57, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "폴더 경로 :";
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.path_label.Location = new System.Drawing.Point(164, 427);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(0, 18);
            this.path_label.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(972, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "저장경로 지정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save_path_label
            // 
            this.Save_path_label.AutoSize = true;
            this.Save_path_label.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Save_path_label.Location = new System.Drawing.Point(1110, 382);
            this.Save_path_label.Name = "Save_path_label";
            this.Save_path_label.Size = new System.Drawing.Size(15, 18);
            this.Save_path_label.TabIndex = 2;
            this.Save_path_label.Text = "-";
            // 
            // Load_button
            // 
            this.Load_button.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Load_button.Location = new System.Drawing.Point(972, 427);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(104, 64);
            this.Load_button.TabIndex = 0;
            this.Load_button.Text = "통합용량표 파일경로";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Load_path_label
            // 
            this.Load_path_label.AutoSize = true;
            this.Load_path_label.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Load_path_label.Location = new System.Drawing.Point(1110, 473);
            this.Load_path_label.Name = "Load_path_label";
            this.Load_path_label.Size = new System.Drawing.Size(15, 18);
            this.Load_path_label.TabIndex = 2;
            this.Load_path_label.Text = "-";
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Location = new System.Drawing.Point(810, 261);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(75, 41);
            this.Clear_Btn.TabIndex = 5;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(1204, 224);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 18);
            this.label25.TabIndex = 2;
            this.label25.Text = "TE 고속사양";
            // 
            // TE_express
            // 
            this.TE_express.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TE_express.FormattingEnabled = true;
            this.TE_express.Items.AddRange(new object[] {
            "적용",
            "미적용"});
            this.TE_express.Location = new System.Drawing.Point(1197, 259);
            this.TE_express.Name = "TE_express";
            this.TE_express.Size = new System.Drawing.Size(100, 20);
            this.TE_express.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 555);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.Pdf_convert);
            this.Controls.Add(this.EXTconsent2_amount);
            this.Controls.Add(this.EXTconsent2);
            this.Controls.Add(this.EXTconsent1_amount);
            this.Controls.Add(this.Standard_text);
            this.Controls.Add(this.ERP_Number);
            this.Controls.Add(this.Machine_4);
            this.Controls.Add(this.Machine_3);
            this.Controls.Add(this.Machine_2);
            this.Controls.Add(this.Machine_1);
            this.Controls.Add(this.Company_name);
            this.Controls.Add(this.Factory_Voltage);
            this.Controls.Add(this.Hotrun_capacity);
            this.Controls.Add(this.Hotrunner);
            this.Controls.Add(this.EXTconsent1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Hotrun_2nd_volt);
            this.Controls.Add(this.Hotrun_1st_volt);
            this.Controls.Add(this.SG_Phase_2nd_volt);
            this.Controls.Add(this.SG_Phase_1st_volt);
            this.Controls.Add(this.Motor_2nd_volt);
            this.Controls.Add(this.Motor_1st_volt);
            this.Controls.Add(this.Main_2nd_volt);
            this.Controls.Add(this.Main_1st_volt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Load_path_label);
            this.Controls.Add(this.Save_path_label);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Injection_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Hotrun_trans_use);
            this.Controls.Add(this.SG_Phase_trans_use);
            this.Controls.Add(this.Motor_trans_use);
            this.Controls.Add(this.Hotrun_N_use);
            this.Controls.Add(this.CG_Motor_use);
            this.Controls.Add(this.TE_express);
            this.Controls.Add(this.THA5_Motor_2_use);
            this.Controls.Add(this.Main_trans_use);
            this.Controls.Add(this.Ton_category);
            this.Controls.Add(this.Main_category);
            this.Controls.Add(this.folder_crt_btn);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Create_Btn);
            this.Controls.Add(this.path_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.ComboBox Main_category;
        private System.Windows.Forms.ComboBox Ton_category;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Injection_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EXTconsent1;
        private System.Windows.Forms.TextBox EXTconsent1_amount;
        private System.Windows.Forms.TextBox EXTconsent2;
        private System.Windows.Forms.TextBox EXTconsent2_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Hotrunner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Factory_Voltage;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox Standard_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ERP_Number;
        private System.Windows.Forms.TextBox Company_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        
        private System.Windows.Forms.Button folder_crt_btn;
        private System.Windows.Forms.TextBox Machine_4;
        private System.Windows.Forms.TextBox Machine_3;
        private System.Windows.Forms.TextBox Machine_2;
        private System.Windows.Forms.TextBox Machine_1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Hotrun_2nd_volt;
        private System.Windows.Forms.TextBox Hotrun_1st_volt;
        private System.Windows.Forms.TextBox SG_Phase_2nd_volt;
        private System.Windows.Forms.TextBox SG_Phase_1st_volt;
        private System.Windows.Forms.TextBox Motor_2nd_volt;
        private System.Windows.Forms.TextBox Motor_1st_volt;
        private System.Windows.Forms.TextBox Main_2nd_volt;
        private System.Windows.Forms.TextBox Main_1st_volt;
        private System.Windows.Forms.ComboBox Hotrun_trans_use;
        private System.Windows.Forms.ComboBox SG_Phase_trans_use;
        private System.Windows.Forms.ComboBox Motor_trans_use;
        private System.Windows.Forms.ComboBox Main_trans_use;
        private System.Windows.Forms.TextBox Hotrun_capacity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox Hotrun_N_use;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox CG_Motor_use;
        private System.Windows.Forms.ComboBox THA5_Motor_2_use;
        private System.Windows.Forms.CheckBox Pdf_convert;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label path_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Save_path_label;
        private System.Windows.Forms.Label Load_path_label;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox TE_express;

    }
}

