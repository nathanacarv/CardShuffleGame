namespace CardShuffleGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnDealCards = new Button();
            userCardsLabelText = new Label();
            computerCardsLabelText = new Label();
            userPicBox1 = new PictureBox();
            userPicBox2 = new PictureBox();
            userPicBox3 = new PictureBox();
            computerPicBox1 = new PictureBox();
            computerPicBox2 = new PictureBox();
            computerPicBox3 = new PictureBox();
            userScoreLblTxt = new Label();
            computerScoreLblTxt = new Label();
            userScoreValueTxtBox = new TextBox();
            computerScoreValueTxtBox = new TextBox();
            winnerLblDisplay = new Label();
            cardDeckImageList = new ImageList(components);
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)userPicBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPicBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPicBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerPicBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerPicBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerPicBox3).BeginInit();
            SuspendLayout();
            // 
            // btnDealCards
            // 
            btnDealCards.BackColor = SystemColors.ActiveCaption;
            btnDealCards.FlatStyle = FlatStyle.Flat;
            btnDealCards.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDealCards.ForeColor = SystemColors.ActiveCaptionText;
            btnDealCards.Location = new Point(385, 931);
            btnDealCards.Name = "btnDealCards";
            btnDealCards.Size = new Size(289, 103);
            btnDealCards.TabIndex = 0;
            btnDealCards.Text = "Deal Cards";
            btnDealCards.UseVisualStyleBackColor = false;
            btnDealCards.Click += btnDealCards_Click;
            // 
            // userCardsLabelText
            // 
            userCardsLabelText.AutoSize = true;
            userCardsLabelText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userCardsLabelText.Location = new Point(33, 71);
            userCardsLabelText.Name = "userCardsLabelText";
            userCardsLabelText.Size = new Size(185, 45);
            userCardsLabelText.TabIndex = 1;
            userCardsLabelText.Text = "Your cards:";
            // 
            // computerCardsLabelText
            // 
            computerCardsLabelText.AutoSize = true;
            computerCardsLabelText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            computerCardsLabelText.Location = new Point(33, 474);
            computerCardsLabelText.Name = "computerCardsLabelText";
            computerCardsLabelText.Size = new Size(293, 45);
            computerCardsLabelText.TabIndex = 2;
            computerCardsLabelText.Text = "Computer's Cards:";
            // 
            // userPicBox1
            // 
            userPicBox1.BorderStyle = BorderStyle.FixedSingle;
            userPicBox1.Image = Properties.Resources.faceDownCard;
            userPicBox1.Location = new Point(47, 129);
            userPicBox1.Name = "userPicBox1";
            userPicBox1.Size = new Size(209, 254);
            userPicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicBox1.TabIndex = 3;
            userPicBox1.TabStop = false;
            // 
            // userPicBox2
            // 
            userPicBox2.BorderStyle = BorderStyle.FixedSingle;
            userPicBox2.Image = Properties.Resources.faceDownCard;
            userPicBox2.Location = new Point(397, 129);
            userPicBox2.Name = "userPicBox2";
            userPicBox2.Size = new Size(209, 254);
            userPicBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicBox2.TabIndex = 4;
            userPicBox2.TabStop = false;
            // 
            // userPicBox3
            // 
            userPicBox3.BorderStyle = BorderStyle.FixedSingle;
            userPicBox3.Image = Properties.Resources.faceDownCard;
            userPicBox3.Location = new Point(738, 129);
            userPicBox3.Name = "userPicBox3";
            userPicBox3.Size = new Size(209, 254);
            userPicBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicBox3.TabIndex = 5;
            userPicBox3.TabStop = false;
            // 
            // computerPicBox1
            // 
            computerPicBox1.BorderStyle = BorderStyle.FixedSingle;
            computerPicBox1.Image = Properties.Resources.faceDownCard;
            computerPicBox1.Location = new Point(47, 547);
            computerPicBox1.Name = "computerPicBox1";
            computerPicBox1.Size = new Size(209, 254);
            computerPicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            computerPicBox1.TabIndex = 6;
            computerPicBox1.TabStop = false;
            // 
            // computerPicBox2
            // 
            computerPicBox2.BorderStyle = BorderStyle.FixedSingle;
            computerPicBox2.Image = Properties.Resources.faceDownCard;
            computerPicBox2.Location = new Point(397, 547);
            computerPicBox2.Name = "computerPicBox2";
            computerPicBox2.Size = new Size(209, 254);
            computerPicBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            computerPicBox2.TabIndex = 7;
            computerPicBox2.TabStop = false;
            // 
            // computerPicBox3
            // 
            computerPicBox3.BorderStyle = BorderStyle.FixedSingle;
            computerPicBox3.Image = Properties.Resources.faceDownCard;
            computerPicBox3.Location = new Point(738, 547);
            computerPicBox3.Name = "computerPicBox3";
            computerPicBox3.Size = new Size(209, 254);
            computerPicBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            computerPicBox3.TabIndex = 8;
            computerPicBox3.TabStop = false;
            // 
            // userScoreLblTxt
            // 
            userScoreLblTxt.AutoSize = true;
            userScoreLblTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userScoreLblTxt.Location = new Point(433, 71);
            userScoreLblTxt.Name = "userScoreLblTxt";
            userScoreLblTxt.Size = new Size(112, 45);
            userScoreLblTxt.TabIndex = 9;
            userScoreLblTxt.Text = "Score:";
            // 
            // computerScoreLblTxt
            // 
            computerScoreLblTxt.AutoSize = true;
            computerScoreLblTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            computerScoreLblTxt.Location = new Point(433, 474);
            computerScoreLblTxt.Name = "computerScoreLblTxt";
            computerScoreLblTxt.Size = new Size(112, 45);
            computerScoreLblTxt.TabIndex = 10;
            computerScoreLblTxt.Text = "Score:";
            // 
            // userScoreValueTxtBox
            // 
            userScoreValueTxtBox.Location = new Point(583, 78);
            userScoreValueTxtBox.Name = "userScoreValueTxtBox";
            userScoreValueTxtBox.Size = new Size(184, 39);
            userScoreValueTxtBox.TabIndex = 11;
            // 
            // computerScoreValueTxtBox
            // 
            computerScoreValueTxtBox.Location = new Point(583, 481);
            computerScoreValueTxtBox.Name = "computerScoreValueTxtBox";
            computerScoreValueTxtBox.Size = new Size(184, 39);
            computerScoreValueTxtBox.TabIndex = 12;
            // 
            // winnerLblDisplay
            // 
            winnerLblDisplay.Location = new Point(1283, 135);
            winnerLblDisplay.Name = "winnerLblDisplay";
            winnerLblDisplay.Size = new Size(361, 135);
            winnerLblDisplay.TabIndex = 13;
            // 
            // cardDeckImageList
            // 
            cardDeckImageList.ColorDepth = ColorDepth.Depth32Bit;
            cardDeckImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardDeckImageList.ImageStream");
            cardDeckImageList.TransparentColor = Color.Transparent;
            cardDeckImageList.Images.SetKeyName(0, "clubAce.jpg");
            cardDeckImageList.Images.SetKeyName(1, "club2.jpg");
            cardDeckImageList.Images.SetKeyName(2, "club3.jpg");
            cardDeckImageList.Images.SetKeyName(3, "club4.jpg");
            cardDeckImageList.Images.SetKeyName(4, "club5.jpg");
            cardDeckImageList.Images.SetKeyName(5, "club6.jpg");
            cardDeckImageList.Images.SetKeyName(6, "club7.jpg");
            cardDeckImageList.Images.SetKeyName(7, "club8.jpg");
            cardDeckImageList.Images.SetKeyName(8, "club9.jpg");
            cardDeckImageList.Images.SetKeyName(9, "club10.jpg");
            cardDeckImageList.Images.SetKeyName(10, "club11.jpg");
            cardDeckImageList.Images.SetKeyName(11, "club12.jpg");
            cardDeckImageList.Images.SetKeyName(12, "club13.jpg");
            cardDeckImageList.Images.SetKeyName(13, "diamondAce.jpg");
            cardDeckImageList.Images.SetKeyName(14, "diamond2.jpg");
            cardDeckImageList.Images.SetKeyName(15, "diamond3.jpg");
            cardDeckImageList.Images.SetKeyName(16, "diamond4.jpg");
            cardDeckImageList.Images.SetKeyName(17, "diamond5.jpg");
            cardDeckImageList.Images.SetKeyName(18, "diamond6.jpg");
            cardDeckImageList.Images.SetKeyName(19, "diamond7.jpg");
            cardDeckImageList.Images.SetKeyName(20, "diamond8.jpg");
            cardDeckImageList.Images.SetKeyName(21, "diamond9.jpg");
            cardDeckImageList.Images.SetKeyName(22, "diamond10.jpg");
            cardDeckImageList.Images.SetKeyName(23, "diamond11.jpg");
            cardDeckImageList.Images.SetKeyName(24, "diamond12.jpg");
            cardDeckImageList.Images.SetKeyName(25, "diamond13.jpg");
            cardDeckImageList.Images.SetKeyName(26, "heartAce.jpg");
            cardDeckImageList.Images.SetKeyName(27, "heart2.jpg");
            cardDeckImageList.Images.SetKeyName(28, "heart3.jpg");
            cardDeckImageList.Images.SetKeyName(29, "heart4.jpg");
            cardDeckImageList.Images.SetKeyName(30, "heart5.jpg");
            cardDeckImageList.Images.SetKeyName(31, "heart6.jpg");
            cardDeckImageList.Images.SetKeyName(32, "heart7.jpg");
            cardDeckImageList.Images.SetKeyName(33, "heart8.jpg");
            cardDeckImageList.Images.SetKeyName(34, "heart9.jpg");
            cardDeckImageList.Images.SetKeyName(35, "heart10.jpg");
            cardDeckImageList.Images.SetKeyName(36, "heart11.jpg");
            cardDeckImageList.Images.SetKeyName(37, "heart12.jpg");
            cardDeckImageList.Images.SetKeyName(38, "heart13.jpg");
            cardDeckImageList.Images.SetKeyName(39, "spadeAce.jpg");
            cardDeckImageList.Images.SetKeyName(40, "spade2.jpg");
            cardDeckImageList.Images.SetKeyName(41, "spade3.jpg");
            cardDeckImageList.Images.SetKeyName(42, "spade4.jpg");
            cardDeckImageList.Images.SetKeyName(43, "spade5.jpg");
            cardDeckImageList.Images.SetKeyName(44, "spade6.jpg");
            cardDeckImageList.Images.SetKeyName(45, "spade7.jpg");
            cardDeckImageList.Images.SetKeyName(46, "spade8.jpg");
            cardDeckImageList.Images.SetKeyName(47, "spade9.jpg");
            cardDeckImageList.Images.SetKeyName(48, "spade10.jpg");
            cardDeckImageList.Images.SetKeyName(49, "spade11.jpg");
            cardDeckImageList.Images.SetKeyName(50, "spade12.jpg");
            cardDeckImageList.Images.SetKeyName(51, "spade13.jpg");
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(1181, 931);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(289, 103);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1871, 1095);
            Controls.Add(btnExit);
            Controls.Add(winnerLblDisplay);
            Controls.Add(computerScoreValueTxtBox);
            Controls.Add(userScoreValueTxtBox);
            Controls.Add(computerScoreLblTxt);
            Controls.Add(userScoreLblTxt);
            Controls.Add(computerPicBox3);
            Controls.Add(computerPicBox2);
            Controls.Add(computerPicBox1);
            Controls.Add(userPicBox3);
            Controls.Add(userPicBox2);
            Controls.Add(userPicBox1);
            Controls.Add(computerCardsLabelText);
            Controls.Add(userCardsLabelText);
            Controls.Add(btnDealCards);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userPicBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPicBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPicBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerPicBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerPicBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerPicBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDealCards;
        private Label userCardsLabelText;
        private Label computerCardsLabelText;
        private PictureBox userPicBox1;
        private PictureBox userPicBox2;
        private PictureBox userPicBox3;
        private PictureBox computerPicBox1;
        private PictureBox computerPicBox2;
        private PictureBox computerPicBox3;
        private Label userScoreLblTxt;
        private Label computerScoreLblTxt;
        private TextBox userScoreValueTxtBox;
        private TextBox computerScoreValueTxtBox;
        private Label winnerLblDisplay;
        private ImageList cardDeckImageList;
        private Button btnExit;
    }
}
