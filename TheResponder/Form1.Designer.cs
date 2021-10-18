namespace TheResponder
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtDrop = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.UserId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.TextMessage = new System.Windows.Forms.RichTextBox();
            this.FileLocation = new System.Windows.Forms.Label();
            this.LineId = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LineMess = new System.Windows.Forms.Panel();
            this.LineDrop = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btClearFile = new System.Windows.Forms.Button();
            this.LineSend = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtError = new System.Windows.Forms.Label();
            this.txtBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Token = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.Label();
            this.LineSendReady = new System.Windows.Forms.Panel();
            this.LineToken = new System.Windows.Forms.Panel();
            this.ChatHistory = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btStopChat = new System.Windows.Forms.Button();
            this.btClearChat = new System.Windows.Forms.Button();
            this.txtChatHistory = new System.Windows.Forms.Label();
            this.LineChatHistory = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(477, 208);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.DragLeave += new System.EventHandler(this.listBox1_DragLeave);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            // 
            // txtDrop
            // 
            this.txtDrop.AllowDrop = true;
            this.txtDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.txtDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDrop.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDrop.ForeColor = System.Drawing.Color.DimGray;
            this.txtDrop.Location = new System.Drawing.Point(12, 179);
            this.txtDrop.Name = "txtDrop";
            this.txtDrop.Size = new System.Drawing.Size(477, 26);
            this.txtDrop.TabIndex = 1;
            this.txtDrop.Text = "DROP FILE";
            this.txtDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.txtDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.txtDrop.DragLeave += new System.EventHandler(this.listBox1_DragLeave);
            this.txtDrop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.txtDrop.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.txtDrop.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            // 
            // btSend
            // 
            this.btSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.btSend.FlatAppearance.BorderSize = 0;
            this.btSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSend.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSend.ForeColor = System.Drawing.Color.DimGray;
            this.btSend.Location = new System.Drawing.Point(325, 484);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(164, 33);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.button1_Click);
            this.btSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.btSend.MouseEnter += new System.EventHandler(this.btStopChat_MouseEnter);
            this.btSend.MouseLeave += new System.EventHandler(this.btStopChat_MouseLeave);
            // 
            // UserId
            // 
            this.UserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.UserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserId.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.UserId.Location = new System.Drawing.Point(177, 319);
            this.UserId.MaxLength = 9;
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(141, 27);
            this.UserId.TabIndex = 2;
            this.UserId.TabStop = false;
            this.UserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserId_MouseClick);
            this.UserId.TextChanged += new System.EventHandler(this.UserId_TextChanged);
            this.UserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.UserId.MouseEnter += new System.EventHandler(this.UserId_MouseEnter);
            this.UserId.MouseLeave += new System.EventHandler(this.UserId_MouseLeave);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.ForeColor = System.Drawing.Color.DimGray;
            this.txtId.Location = new System.Drawing.Point(188, 320);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(118, 26);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "ID";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtId.UseCompatibleTextRendering = true;
            this.txtId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserId_MouseClick);
            this.txtId.MouseEnter += new System.EventHandler(this.UserId_MouseEnter);
            this.txtId.MouseLeave += new System.EventHandler(this.UserId_MouseLeave);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessage.ForeColor = System.Drawing.Color.DimGray;
            this.txtMessage.Location = new System.Drawing.Point(22, 390);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(87, 20);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "Message...";
            this.txtMessage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextMessage_MouseClick);
            this.txtMessage.MouseEnter += new System.EventHandler(this.TextMessage_MouseEnter);
            this.txtMessage.MouseLeave += new System.EventHandler(this.TextMessage_MouseLeave);
            // 
            // TextMessage
            // 
            this.TextMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.TextMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextMessage.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.TextMessage.Location = new System.Drawing.Point(20, 389);
            this.TextMessage.MaxLength = 5000;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextMessage.Size = new System.Drawing.Size(461, 80);
            this.TextMessage.TabIndex = 5;
            this.TextMessage.TabStop = false;
            this.TextMessage.Text = "";
            this.TextMessage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextMessage_MouseClick);
            this.TextMessage.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.TextMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.TextMessage.MouseEnter += new System.EventHandler(this.TextMessage_MouseEnter);
            this.TextMessage.MouseLeave += new System.EventHandler(this.TextMessage_MouseLeave);
            // 
            // FileLocation
            // 
            this.FileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.FileLocation.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.FileLocation.Location = new System.Drawing.Point(17, 269);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(472, 26);
            this.FileLocation.TabIndex = 4;
            this.FileLocation.Text = "File";
            this.FileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileLocation.Visible = false;
            // 
            // LineId
            // 
            this.LineId.BackColor = System.Drawing.Color.White;
            this.LineId.Location = new System.Drawing.Point(192, 348);
            this.LineId.Name = "LineId";
            this.LineId.Size = new System.Drawing.Size(110, 1);
            this.LineId.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.LineMess);
            this.panel1.Location = new System.Drawing.Point(12, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 101);
            this.panel1.TabIndex = 7;
            this.panel1.MouseEnter += new System.EventHandler(this.TextMessage_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.TextMessage_MouseLeave);
            // 
            // LineMess
            // 
            this.LineMess.BackColor = System.Drawing.Color.White;
            this.LineMess.Location = new System.Drawing.Point(0, 0);
            this.LineMess.Name = "LineMess";
            this.LineMess.Size = new System.Drawing.Size(1, 101);
            this.LineMess.TabIndex = 6;
            // 
            // LineDrop
            // 
            this.LineDrop.BackColor = System.Drawing.Color.White;
            this.LineDrop.Location = new System.Drawing.Point(12, 87);
            this.LineDrop.Name = "LineDrop";
            this.LineDrop.Size = new System.Drawing.Size(1, 208);
            this.LineDrop.TabIndex = 6;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Hans Kendrick", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.btExit.Location = new System.Drawing.Point(1206, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(34, 30);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "X";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.btExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.btExit.MouseEnter += new System.EventHandler(this.btExit_MouseEnter);
            this.btExit.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btClearFile
            // 
            this.btClearFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.btClearFile.FlatAppearance.BorderSize = 0;
            this.btClearFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.btClearFile.Location = new System.Drawing.Point(12, 297);
            this.btClearFile.Name = "btClearFile";
            this.btClearFile.Size = new System.Drawing.Size(74, 24);
            this.btClearFile.TabIndex = 8;
            this.btClearFile.Text = "Сlear file";
            this.btClearFile.UseVisualStyleBackColor = false;
            this.btClearFile.Visible = false;
            this.btClearFile.Click += new System.EventHandler(this.btClear_Click);
            this.btClearFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseDown);
            this.btClearFile.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btClearFile.MouseLeave += new System.EventHandler(this.btClear_MouseLeave);
            this.btClearFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseUp);
            // 
            // LineSend
            // 
            this.LineSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LineSend.BackColor = System.Drawing.Color.White;
            this.LineSend.Location = new System.Drawing.Point(12, 474);
            this.LineSend.Name = "LineSend";
            this.LineSend.Size = new System.Drawing.Size(477, 1);
            this.LineSend.TabIndex = 6;
            this.LineSend.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(489, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 101);
            this.panel2.TabIndex = 9;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.txtError.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.txtError.Location = new System.Drawing.Point(12, 489);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(290, 26);
            this.txtError.TabIndex = 4;
            this.txtError.Text = "Error";
            this.txtError.UseCompatibleTextRendering = true;
            this.txtError.Visible = false;
            // 
            // txtBy
            // 
            this.txtBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.txtBy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBy.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.txtBy.Location = new System.Drawing.Point(992, 12);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(131, 19);
            this.txtBy.TabIndex = 4;
            this.txtBy.Text = "by @CMETAHKA";
            this.txtBy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.txtBy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.txtBy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.label2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "The Responder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Token
            // 
            this.Token.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Token.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Token.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Token.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.Token.Location = new System.Drawing.Point(89, 64);
            this.Token.MaxLength = 48;
            this.Token.Name = "Token";
            this.Token.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Token.Size = new System.Drawing.Size(400, 19);
            this.Token.TabIndex = 10;
            this.Token.TabStop = false;
            this.Token.Text = "758482488:AAHWAPLTxeD__hH2Gqf2omQptnS42_RcD9s";
            this.Token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Token.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Token_MouseClick);
            this.Token.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Token.MouseEnter += new System.EventHandler(this.Token_MouseEnter);
            this.Token.MouseLeave += new System.EventHandler(this.Token_MouseLeave);
            // 
            // txtToken
            // 
            this.txtToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.txtToken.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.txtToken.Location = new System.Drawing.Point(11, 59);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(85, 26);
            this.txtToken.TabIndex = 4;
            this.txtToken.Text = "TOKEN:";
            // 
            // LineSendReady
            // 
            this.LineSendReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.LineSendReady.Location = new System.Drawing.Point(12, 40);
            this.LineSendReady.Name = "LineSendReady";
            this.LineSendReady.Size = new System.Drawing.Size(477, 1);
            this.LineSendReady.TabIndex = 6;
            // 
            // LineToken
            // 
            this.LineToken.BackColor = System.Drawing.Color.White;
            this.LineToken.Location = new System.Drawing.Point(12, 63);
            this.LineToken.Name = "LineToken";
            this.LineToken.Size = new System.Drawing.Size(1, 19);
            this.LineToken.TabIndex = 6;
            // 
            // ChatHistory
            // 
            this.ChatHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ChatHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.ChatHistory.Location = new System.Drawing.Point(513, 87);
            this.ChatHistory.Name = "ChatHistory";
            this.ChatHistory.ReadOnly = true;
            this.ChatHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChatHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatHistory.ShowSelectionMargin = true;
            this.ChatHistory.Size = new System.Drawing.Size(715, 390);
            this.ChatHistory.TabIndex = 11;
            this.ChatHistory.Text = "";
            this.ChatHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.ChatHistory.TextChanged += new System.EventHandler(this.ChatHistory_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 4000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Message info:";
            // 
            // btStopChat
            // 
            this.btStopChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStopChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.btStopChat.FlatAppearance.BorderSize = 0;
            this.btStopChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btStopChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStopChat.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStopChat.ForeColor = System.Drawing.Color.DimGray;
            this.btStopChat.Location = new System.Drawing.Point(513, 484);
            this.btStopChat.Name = "btStopChat";
            this.btStopChat.Size = new System.Drawing.Size(164, 33);
            this.btStopChat.TabIndex = 3;
            this.btStopChat.Text = "Start Chat";
            this.btStopChat.UseVisualStyleBackColor = false;
            this.btStopChat.Click += new System.EventHandler(this.button1_Click_1);
            this.btStopChat.MouseEnter += new System.EventHandler(this.btStopChat_MouseEnter);
            this.btStopChat.MouseLeave += new System.EventHandler(this.btStopChat_MouseLeave);
            // 
            // btClearChat
            // 
            this.btClearChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.btClearChat.FlatAppearance.BorderSize = 0;
            this.btClearChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btClearChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearChat.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClearChat.ForeColor = System.Drawing.Color.DimGray;
            this.btClearChat.Location = new System.Drawing.Point(1064, 484);
            this.btClearChat.Name = "btClearChat";
            this.btClearChat.Size = new System.Drawing.Size(164, 33);
            this.btClearChat.TabIndex = 3;
            this.btClearChat.Text = "Clear Chat";
            this.btClearChat.UseVisualStyleBackColor = false;
            this.btClearChat.Click += new System.EventHandler(this.button1_Click_2);
            this.btClearChat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btClearChat_MouseDown);
            this.btClearChat.MouseEnter += new System.EventHandler(this.btClearChat_MouseEnter);
            this.btClearChat.MouseLeave += new System.EventHandler(this.btClearChat_MouseLeave);
            this.btClearChat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClearChat_MouseUp);
            // 
            // txtChatHistory
            // 
            this.txtChatHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.txtChatHistory.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtChatHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.txtChatHistory.Location = new System.Drawing.Point(513, 58);
            this.txtChatHistory.Name = "txtChatHistory";
            this.txtChatHistory.Size = new System.Drawing.Size(715, 26);
            this.txtChatHistory.TabIndex = 4;
            this.txtChatHistory.Text = "CHAT HISTORY";
            this.txtChatHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineChatHistory
            // 
            this.LineChatHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.LineChatHistory.Location = new System.Drawing.Point(513, 40);
            this.LineChatHistory.Name = "LineChatHistory";
            this.LineChatHistory.Size = new System.Drawing.Size(715, 1);
            this.LineChatHistory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(124, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "for Telegram Bot";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Hans Kendrick", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.button1.Location = new System.Drawing.Point(1172, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "□";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.MouseEnter += new System.EventHandler(this.btExit_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Hans Kendrick", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.button2.Location = new System.Drawing.Point(1138, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button2.MouseEnter += new System.EventHandler(this.btExit_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Settings";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1240, 525);
            this.Controls.Add(this.ChatHistory);
            this.Controls.Add(this.LineToken);
            this.Controls.Add(this.Token);
            this.Controls.Add(this.btClearFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.LineSend);
            this.Controls.Add(this.LineChatHistory);
            this.Controls.Add(this.LineSendReady);
            this.Controls.Add(this.LineDrop);
            this.Controls.Add(this.LineId);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtChatHistory);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btClearChat);
            this.Controls.Add(this.btStopChat);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.txtDrop);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1920);
            this.MinimumSize = new System.Drawing.Size(1240, 525);
            this.Name = "Form1";
            this.Text = "The Defendant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label txtDrop;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label FileLocation;
        private System.Windows.Forms.Panel LineId;
        private System.Windows.Forms.RichTextBox TextMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LineDrop;
        private System.Windows.Forms.Panel LineMess;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btClearFile;
        private System.Windows.Forms.Panel LineSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Label txtBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Token;
        private System.Windows.Forms.Label txtToken;
        private System.Windows.Forms.Panel LineSendReady;
        private System.Windows.Forms.Panel LineToken;
        private System.Windows.Forms.RichTextBox ChatHistory;
        private System.Windows.Forms.Button btStopChat;
        private System.Windows.Forms.Button btClearChat;
        private System.Windows.Forms.Label txtChatHistory;
        private System.Windows.Forms.Panel LineChatHistory;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

