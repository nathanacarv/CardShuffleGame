using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CardShuffleGame
{
    public partial class Form1 : Form
    {
        // declare and initialize random object
        Random rnd = new Random();

        //list to store dealt cards
        List<int> userDealtCardsNumValue = new List<int>();
        List<int> computerDealtCardsNumValue = new List<int>();

        //dictionary to track cards key-value pairs
        Dictionary<int, int> cardValueTracking;

        //declare picture box arrays
        PictureBox[] userPictureBoxes;
        PictureBox[] computerPictureBoxes;

        public Form1()
        {
            InitializeComponent();

            //initialize picture box arrays
            userPictureBoxes = new PictureBox[] { userPicBox1, userPicBox2, userPicBox3 };
            computerPictureBoxes = new PictureBox[] { computerPicBox1, computerPicBox2, computerPicBox3 };

            //inititalize dictionary to track card values
            cardValueTracking = new Dictionary<int, int>
            {
                { 0, 1 },  //ace of clubs
                { 1, 2 },  //2 of clubs
                { 2, 3 },  //3 of clubs
                { 3, 4 },  //4 of clubs
                { 4, 5 },  //5 of clubs
                { 5, 6 },  //6 of clubs
                { 6, 7 },  //7 of clubs
                { 7, 8 },  //8 of clubs
                { 8, 9 },  //9 of clubs
                { 9, 10 }, //10 of clubs
                { 10, 11 }, //jack of clubs
                { 11, 12 }, //queen of clubs
                { 12, 13 }, //king of clubs
                { 13, 1 },  //ace of diamonds
                { 14, 2 },  //2 of diamonds
                { 15, 3 },  //3 of diamonds
                { 16, 4 },  //4 of diamonds
                { 17, 5 },  //5 of diamonds
                { 18, 6 },  //6 of diamonds
                { 19, 7 },  //7 of diamonds
                { 20, 8 },  //8 of diamonds
                { 21, 9 },  //9 of diamonds
                { 22, 10 }, //10 of diamonds
                { 23, 11 }, //jack of diamonds
                { 24, 12 }, //queen of diamonds
                { 25, 13 }, //king of diamonds
                { 26, 1 },  //ace of hearts
                { 27, 2 },  //2 of hearts
                { 28, 3 },  //3 of hearts
                { 29, 4 },  //4 of hearts
                { 30, 5 },  //5 of hearts
                { 31, 6 },  //6 of hearts
                { 32, 7 },  //7 of hearts
                { 33, 8 },  //8 of hearts
                { 34, 9 },  //9 of hearts
                { 35, 10 }, //10 of hearts
                { 36, 11 }, //jack of hearts
                { 37, 12 }, //queen of hearts
                { 38, 13 }, //king of hearts
                { 39, 1 },  //ace of spades
                { 40, 2 },  //2 of spades
                { 41, 3 },  //3 of spades
                { 42, 4 }, //4 of spades
                { 43, 5 }, //5 of spades
                { 44, 6 }, //6 of spades
                { 45, 7 }, //7 of spades
                { 46, 8 }, //8 of spades
                { 47, 9 }, //9 of spades
                { 48, 10 }, //10 of spades
                { 49, 11 }, //jack of spades
                { 50, 12 }, //queen of spades
                { 51, 13 }, //king of spades
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDealCards_Click(object sender, EventArgs e)
        {
            //prevent more than 1 click
            btnDealCards.Enabled = false;

            //gets the image for user and computer cards
            getCardImage(userPicBox1);
            getCardImage(userPicBox2);
            getCardImage(userPicBox3);
            getCardImage(computerPicBox1);
            getCardImage(computerPicBox2);
            getCardImage(computerPicBox3);

            //calculate score and display winner
            calculateScore();

            //show exit button after dealing cards
            btnExit.Visible = true;


        }



        //#################################################################################

        //method that gets the picture from image list "cardDeckImageList" 

        private void getCardImage(PictureBox pictureBox)
        {
            userDealtCardsNumValue.Clear();
            computerDealtCardsNumValue.Clear();

            //convert the keys to a list
            List<int> dictionaryKeys = cardValueTracking.Keys.ToList();

            //pick random key index from list
            int randomKeyIndex = rnd.Next(dictionaryKeys.Count);

            //get random element from dictionary keys list at random index
            int randomKeyElement = dictionaryKeys[randomKeyIndex];

            //deal and display user cards
            for (int i = 0; i < 3; i++)
            {
                int randomIndex = rnd.Next(dictionaryKeys.Count);
                int randomKey = dictionaryKeys[randomIndex];

                userPictureBoxes[i].Image = cardDeckImageList.Images[randomKey];
                userDealtCardsNumValue.Add(randomKey);

                //remove the dealt card from the list
                dictionaryKeys.RemoveAt(randomIndex);
            }

            //deal and display computer cards
            for (int i = 0; i < 3; i++)
            {
                int randomIndex = rnd.Next(dictionaryKeys.Count);
                int randomKey = dictionaryKeys[randomIndex];

                computerPictureBoxes[i].Image = cardDeckImageList.Images[randomKey];
                computerDealtCardsNumValue.Add(randomKey);

                //remove the dealt card from the list
                dictionaryKeys.RemoveAt(randomIndex);
            }
        }


        //method that sums up the numerical values for the displayed cards
        private void calculateScore()
        {
            int userScore = 0;
            int computerScore = 0;

            //calculate user score
            foreach (int num in userDealtCardsNumValue)
            {
                int value = cardValueTracking[num];
                userScore += value;
                //MessageBox.Show($"User card index: {num}, value: {value}, userScore: {userScore}"); //debug line
            }
            //display score
            userScoreValueTxtBox.Text = Convert.ToString(userScore);

            //calculate computer score
            foreach (int num in computerDealtCardsNumValue)
            {
                int value = cardValueTracking[num];
                computerScore += value;
                //MessageBox.Show($"Computer card index: {num}, value: {value}, computerScore: {computerScore}"); //debug line
            }
            //display score
            computerScoreValueTxtBox.Text = Convert.ToString(computerScore);

            if (userScore > computerScore)
            {
                Label winnerLabel = new Label();
                this.Controls.Add(winnerLabel);
                winnerLabel.AutoSize = false;
                winnerLabel.Location = new System.Drawing.Point(1300, 481);
                winnerLabel.Size = new System.Drawing.Size(200, 200);
                winnerLabel.Text = $"You Won!";
                winnerLabel.ForeColor = Color.White;
                winnerLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                winnerLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
            else if (userScore < computerScore)
            {
                Label winnerLabel = new Label();
                this.Controls.Add(winnerLabel);
                winnerLabel.AutoSize = false;
                winnerLabel.Location = new System.Drawing.Point(1300, 481);
                winnerLabel.Size = new System.Drawing.Size(200, 200);
                winnerLabel.Text = $"Computer Won!";
                winnerLabel.ForeColor = Color.White;
                winnerLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                winnerLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                Label winnerLabel = new Label();
                this.Controls.Add(winnerLabel);
                winnerLabel.AutoSize = false;
                winnerLabel.Location = new System.Drawing.Point(1300, 481);
                winnerLabel.Size = new System.Drawing.Size(200, 200);
                winnerLabel.Text = $"It is a tie!";
                winnerLabel.ForeColor = Color.White;
                winnerLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                winnerLabel.TextAlign = ContentAlignment.MiddleCenter;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
