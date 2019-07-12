using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;

namespace SnakeGame
{
    public class GameText
    {
        public Text ScoreText { get; set; }
        public Text GameOverText { get; set; }
        public Font FontFaimly { get; set; }
        public string Score { get; set; }
        private string _GameOverMessage;
        private string _ScoreMessage = "Points: ";
        public GameText(string score, string fontFaimly = "Roboto-Regular.ttf")
        {
            Score = score;
            FontFaimly = new Font(fontFaimly);
            ScoreText = new Text(_ScoreMessage + Score, FontFaimly,16);
            _GameOverMessage = "GAMEOVER! You got " + Score + " points GOOD JOB!, hit SPACE to try again";
            GameOverText = new Text(_GameOverMessage, FontFaimly,16);
            GameOverText.Position = new SFML.System.Vector2f(70f, 300f);
        }
    }
}
