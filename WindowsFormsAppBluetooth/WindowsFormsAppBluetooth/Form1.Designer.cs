namespace WindowsFormsAppBluetooth
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.textBoxSigninPassword = new System.Windows.Forms.TextBox();
            this.textBoxSigninUsername = new System.Windows.Forms.TextBox();
            this.labelSigninPassword = new System.Windows.Forms.Label();
            this.labelSiginUserName = new System.Windows.Forms.Label();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxSignupPassword = new System.Windows.Forms.TextBox();
            this.textBoxSignupUsername = new System.Windows.Forms.TextBox();
            this.textBoxSignupName = new System.Windows.Forms.TextBox();
            this.labelSignupPassword = new System.Windows.Forms.Label();
            this.labelSignUpUsername = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelAfterSignin = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonConnectAvailable = new System.Windows.Forms.Button();
            this.labelAvailableConnection = new System.Windows.Forms.Label();
            this.panelIncomming = new System.Windows.Forms.Panel();
            this.buttonConnectIncomming = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelMessage = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelSignUpTittle = new System.Windows.Forms.Label();
            this.buttonAvailable = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.labelSignin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelSignup.SuspendLayout();
            this.panelAfterSignin.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelIncomming.SuspendLayout();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.panelLogin.Controls.Add(this.labelSignin);
            this.panelLogin.Controls.Add(this.buttonSignup);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.buttonSignin);
            this.panelLogin.Controls.Add(this.pictureBoxTitle);
            this.panelLogin.Controls.Add(this.textBoxSigninPassword);
            this.panelLogin.Controls.Add(this.textBoxSigninUsername);
            this.panelLogin.Controls.Add(this.labelSigninPassword);
            this.panelLogin.Controls.Add(this.labelSiginUserName);
            this.panelLogin.Location = new System.Drawing.Point(3, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(796, 676);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // buttonSignup
            // 
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSignup.Location = new System.Drawing.Point(321, 585);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(125, 46);
            this.buttonSignup.TabIndex = 7;
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(93, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Need new Account?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSignin
            // 
            this.buttonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSignin.Location = new System.Drawing.Point(161, 453);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(402, 49);
            this.buttonSignin.TabIndex = 6;
            this.buttonSignin.Text = "Sign in";
            this.buttonSignin.UseVisualStyleBackColor = true;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // textBoxSigninPassword
            // 
            this.textBoxSigninPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSigninPassword.Location = new System.Drawing.Point(161, 373);
            this.textBoxSigninPassword.Name = "textBoxSigninPassword";
            this.textBoxSigninPassword.PasswordChar = '*';
            this.textBoxSigninPassword.Size = new System.Drawing.Size(402, 30);
            this.textBoxSigninPassword.TabIndex = 3;
            // 
            // textBoxSigninUsername
            // 
            this.textBoxSigninUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSigninUsername.Location = new System.Drawing.Point(161, 280);
            this.textBoxSigninUsername.Name = "textBoxSigninUsername";
            this.textBoxSigninUsername.Size = new System.Drawing.Size(402, 30);
            this.textBoxSigninUsername.TabIndex = 2;
            // 
            // labelSigninPassword
            // 
            this.labelSigninPassword.AutoSize = true;
            this.labelSigninPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSigninPassword.Location = new System.Drawing.Point(156, 333);
            this.labelSigninPassword.Name = "labelSigninPassword";
            this.labelSigninPassword.Size = new System.Drawing.Size(98, 25);
            this.labelSigninPassword.TabIndex = 1;
            this.labelSigninPassword.Text = "Password";
            // 
            // labelSiginUserName
            // 
            this.labelSiginUserName.AutoSize = true;
            this.labelSiginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiginUserName.Location = new System.Drawing.Point(156, 242);
            this.labelSiginUserName.Name = "labelSiginUserName";
            this.labelSiginUserName.Size = new System.Drawing.Size(102, 25);
            this.labelSiginUserName.TabIndex = 0;
            this.labelSiginUserName.Text = "Username";
            // 
            // panelSignup
            // 
            this.panelSignup.BackColor = System.Drawing.SystemColors.Control;
            this.panelSignup.Controls.Add(this.labelSignUpTittle);
            this.panelSignup.Controls.Add(this.pictureBox1);
            this.panelSignup.Controls.Add(this.buttonCreateAccount);
            this.panelSignup.Controls.Add(this.buttonBack);
            this.panelSignup.Controls.Add(this.textBoxSignupPassword);
            this.panelSignup.Controls.Add(this.textBoxSignupUsername);
            this.panelSignup.Controls.Add(this.textBoxSignupName);
            this.panelSignup.Controls.Add(this.labelSignupPassword);
            this.panelSignup.Controls.Add(this.labelSignUpUsername);
            this.panelSignup.Controls.Add(this.labelName);
            this.panelSignup.Location = new System.Drawing.Point(817, 12);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(392, 194);
            this.panelSignup.TabIndex = 1;
            this.panelSignup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignup_Paint);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.Location = new System.Drawing.Point(304, 448);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(235, 46);
            this.buttonCreateAccount.TabIndex = 13;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(121, 544);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 47);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxSignupPassword
            // 
            this.textBoxSignupPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignupPassword.Location = new System.Drawing.Point(252, 383);
            this.textBoxSignupPassword.Name = "textBoxSignupPassword";
            this.textBoxSignupPassword.Size = new System.Drawing.Size(328, 30);
            this.textBoxSignupPassword.TabIndex = 11;
            // 
            // textBoxSignupUsername
            // 
            this.textBoxSignupUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignupUsername.Location = new System.Drawing.Point(252, 315);
            this.textBoxSignupUsername.Name = "textBoxSignupUsername";
            this.textBoxSignupUsername.Size = new System.Drawing.Size(328, 30);
            this.textBoxSignupUsername.TabIndex = 10;
            // 
            // textBoxSignupName
            // 
            this.textBoxSignupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignupName.Location = new System.Drawing.Point(252, 244);
            this.textBoxSignupName.Name = "textBoxSignupName";
            this.textBoxSignupName.Size = new System.Drawing.Size(328, 30);
            this.textBoxSignupName.TabIndex = 5;
            this.textBoxSignupName.TextChanged += new System.EventHandler(this.textBoxSignupName_TextChanged);
            // 
            // labelSignupPassword
            // 
            this.labelSignupPassword.AutoSize = true;
            this.labelSignupPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignupPassword.Location = new System.Drawing.Point(115, 388);
            this.labelSignupPassword.Name = "labelSignupPassword";
            this.labelSignupPassword.Size = new System.Drawing.Size(98, 25);
            this.labelSignupPassword.TabIndex = 4;
            this.labelSignupPassword.Text = "Password";
            // 
            // labelSignUpUsername
            // 
            this.labelSignUpUsername.AutoSize = true;
            this.labelSignUpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpUsername.Location = new System.Drawing.Point(111, 318);
            this.labelSignUpUsername.Name = "labelSignUpUsername";
            this.labelSignUpUsername.Size = new System.Drawing.Size(102, 25);
            this.labelSignUpUsername.TabIndex = 3;
            this.labelSignUpUsername.Text = "Username";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(115, 250);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // panelAfterSignin
            // 
            this.panelAfterSignin.BackColor = System.Drawing.SystemColors.Control;
            this.panelAfterSignin.Controls.Add(this.panelSearch);
            this.panelAfterSignin.Controls.Add(this.panelIncomming);
            this.panelAfterSignin.Controls.Add(this.buttonAvailable);
            this.panelAfterSignin.Controls.Add(this.button2);
            this.panelAfterSignin.Location = new System.Drawing.Point(1043, 191);
            this.panelAfterSignin.Name = "panelAfterSignin";
            this.panelAfterSignin.Size = new System.Drawing.Size(228, 60);
            this.panelAfterSignin.TabIndex = 2;
            this.panelAfterSignin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAfterSignin_Paint);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.Window;
            this.panelSearch.Controls.Add(this.buttonConnectAvailable);
            this.panelSearch.Controls.Add(this.labelAvailableConnection);
            this.panelSearch.Location = new System.Drawing.Point(18, 9);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(606, 484);
            this.panelSearch.TabIndex = 3;
            this.panelSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearch_Paint);
            // 
            // buttonConnectAvailable
            // 
            this.buttonConnectAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectAvailable.Location = new System.Drawing.Point(180, 410);
            this.buttonConnectAvailable.Name = "buttonConnectAvailable";
            this.buttonConnectAvailable.Size = new System.Drawing.Size(170, 44);
            this.buttonConnectAvailable.TabIndex = 3;
            this.buttonConnectAvailable.Text = "Connect";
            this.buttonConnectAvailable.UseVisualStyleBackColor = true;
            this.buttonConnectAvailable.Click += new System.EventHandler(this.buttonConnectAvailable_Click);
            // 
            // labelAvailableConnection
            // 
            this.labelAvailableConnection.AutoSize = true;
            this.labelAvailableConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableConnection.Location = new System.Drawing.Point(75, 27);
            this.labelAvailableConnection.Name = "labelAvailableConnection";
            this.labelAvailableConnection.Size = new System.Drawing.Size(416, 46);
            this.labelAvailableConnection.TabIndex = 0;
            this.labelAvailableConnection.Text = "Available Connection";
            // 
            // panelIncomming
            // 
            this.panelIncomming.BackColor = System.Drawing.SystemColors.Window;
            this.panelIncomming.Controls.Add(this.buttonConnectIncomming);
            this.panelIncomming.Controls.Add(this.label2);
            this.panelIncomming.Location = new System.Drawing.Point(18, 21);
            this.panelIncomming.Name = "panelIncomming";
            this.panelIncomming.Size = new System.Drawing.Size(606, 456);
            this.panelIncomming.TabIndex = 3;
            this.panelIncomming.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIncomming_Paint);
            // 
            // buttonConnectIncomming
            // 
            this.buttonConnectIncomming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectIncomming.Location = new System.Drawing.Point(180, 410);
            this.buttonConnectIncomming.Name = "buttonConnectIncomming";
            this.buttonConnectIncomming.Size = new System.Drawing.Size(170, 44);
            this.buttonConnectIncomming.TabIndex = 2;
            this.buttonConnectIncomming.Text = "Connect";
            this.buttonConnectIncomming.UseVisualStyleBackColor = true;
            this.buttonConnectIncomming.Click += new System.EventHandler(this.buttonConnectIncomming_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incomming Request";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.jpg");
            this.imageList1.Images.SetKeyName(1, "incoming.png");
            this.imageList1.Images.SetKeyName(2, "search1.png");
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.SystemColors.Control;
            this.panelMessage.Controls.Add(this.buttonLogout);
            this.panelMessage.Controls.Add(this.buttonSendMessage);
            this.panelMessage.Controls.Add(this.textBox1);
            this.panelMessage.Controls.Add(this.richTextBox1);
            this.panelMessage.Location = new System.Drawing.Point(1043, 274);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(287, 106);
            this.panelMessage.TabIndex = 3;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(273, 507);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(119, 38);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendMessage.Location = new System.Drawing.Point(531, 418);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(131, 42);
            this.buttonSendMessage.TabIndex = 2;
            this.buttonSendMessage.Text = "Send";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(616, 346);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // labelSignUpTittle
            // 
            this.labelSignUpTittle.AutoSize = true;
            this.labelSignUpTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpTittle.Location = new System.Drawing.Point(220, 78);
            this.labelSignUpTittle.Name = "labelSignUpTittle";
            this.labelSignUpTittle.Size = new System.Drawing.Size(217, 59);
            this.labelSignUpTittle.TabIndex = 15;
            this.labelSignUpTittle.Text = "Sign Up";
            // 
            // buttonAvailable
            // 
            this.buttonAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvailable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAvailable.ImageIndex = 0;
            this.buttonAvailable.ImageList = this.imageList1;
            this.buttonAvailable.Location = new System.Drawing.Point(57, 556);
            this.buttonAvailable.Name = "buttonAvailable";
            this.buttonAvailable.Size = new System.Drawing.Size(282, 66);
            this.buttonAvailable.TabIndex = 2;
            this.buttonAvailable.Text = "Available Connection";
            this.buttonAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAvailable.UseVisualStyleBackColor = true;
            this.buttonAvailable.Click += new System.EventHandler(this.buttonAvailable_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(355, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Incomming Request";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppBluetooth.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(36, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxTitle.Image = global::WindowsFormsAppBluetooth.Properties.Resources._2;
            this.pictureBoxTitle.Location = new System.Drawing.Point(36, 43);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(178, 145);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitle.TabIndex = 5;
            this.pictureBoxTitle.TabStop = false;
            // 
            // labelSignin
            // 
            this.labelSignin.AutoSize = true;
            this.labelSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignin.Location = new System.Drawing.Point(220, 78);
            this.labelSignin.Name = "labelSignin";
            this.labelSignin.Size = new System.Drawing.Size(193, 59);
            this.labelSignin.TabIndex = 16;
            this.labelSignin.Text = "Sign In";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 1050);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panelAfterSignin);
            this.Controls.Add(this.panelSignup);
            this.Controls.Add(this.panelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            this.panelAfterSignin.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelIncomming.ResumeLayout(false);
            this.panelIncomming.PerformLayout();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxSigninPassword;
        private System.Windows.Forms.TextBox textBoxSigninUsername;
        private System.Windows.Forms.Label labelSigninPassword;
        private System.Windows.Forms.Label labelSiginUserName;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxSignupPassword;
        private System.Windows.Forms.TextBox textBoxSignupUsername;
        private System.Windows.Forms.TextBox textBoxSignupName;
        private System.Windows.Forms.Label labelSignupPassword;
        private System.Windows.Forms.Label labelSignUpUsername;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelAfterSignin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAvailable;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label labelAvailableConnection;
        private System.Windows.Forms.Panel panelIncomming;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnectIncomming;
        private System.Windows.Forms.Button buttonConnectAvailable;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelSignUpTittle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSignin;
    }
}

