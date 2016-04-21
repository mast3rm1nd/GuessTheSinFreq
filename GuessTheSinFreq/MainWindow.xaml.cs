using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Threading;

namespace GuessTheSinFreq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread BeepingThread;
        public MainWindow()
        {
            InitializeComponent();

            AskQuestion();
        }


        private void Beep_Button_Click(object sender, RoutedEventArgs e)
        {
            //Console.Beep(int.Parse(Frequency_TextBox.Text), int.Parse(Duration_TextBox.Text));
            if(sender != null)
            {
                int freq;
                int dur;

                if (int.TryParse(Frequency_TextBox.Text, out freq))
                {
                    if (freq < _MIN_FREQ || freq > _MAX_FREQ)
                    {
                        Result_Label.Content = String.Format("Частота = {0}..{1}", _MIN_FREQ, _MAX_FREQ);
                        return;
                    }
                }
                else
                {
                    Result_Label.Content = String.Format("Частота = {0}..{1}", _MIN_FREQ, _MAX_FREQ);
                    return;
                }


                if(int.TryParse(Duration_TextBox.Text, out dur))
                {
                    if(dur <= 0)
                    {
                        Result_Label.Content = "Некорректная продолжительность";
                        return;
                    }
                }
                else
                {
                    Result_Label.Content = "Некорректная продолжительность";
                    return;
                }



                InitializeDurationAndFrequency();

                Beep_Button_Click(null, null);
            }
            



            if (BeepingThread != null)
            if (BeepingThread.IsAlive)
                BeepingThread.Abort();

            //if(sender != null)
            //    InitializeDurationAndFrequency();

            BeepingThread = new Thread(new ThreadStart(Beep));
            BeepingThread.IsBackground = true;
            BeepingThread.Start();
        }

        void Beep()
        {
            Console.Beep(frequency, duration);
        }


        int duration;
        int frequency;

        void InitializeDurationAndFrequency()
        {
            duration = int.Parse(Duration_TextBox.Text);
            frequency = int.Parse(Frequency_TextBox.Text);
        }


        static int _MIN_FREQ = 40;
        static int _MAX_FREQ = 16000;
        Random rnd = new Random();
        int rightAnswer;
        void AskQuestion()
        {
            Result_Label.Content = "";

            rightAnswer = rnd.Next(_MIN_FREQ, _MAX_FREQ + 1);

            frequency = rightAnswer;
            duration = 1000;

            // Frequency_TextBox.Text = rightAnswer.ToString();

            Beep_Button_Click(null, null);
        }

        private void RepeatQuestion_Button_Click(object sender, RoutedEventArgs e)
        {
            frequency = rightAnswer;
            duration = 1000;

            Beep_Button_Click(null, null);
        }

        private void MakeAGuess_Button_Click(object sender, RoutedEventArgs e)
        {
            int userVariant;
            if(int.TryParse(UserAnswer_TextBox.Text, out userVariant))
            {
                if(userVariant < _MIN_FREQ || userVariant > _MAX_FREQ)
                {
                    Result_Label.Content = String.Format("Значение = {0}..{1}", _MIN_FREQ, _MAX_FREQ);
                    return;
                }
            }
            else
            {
                Result_Label.Content = String.Format("Значение = {0}..{1}", _MIN_FREQ, _MAX_FREQ);
                return;
            }

            var absDifference = Math.Abs(userVariant - rightAnswer); // 1000 - 10000 = 9000
            var avg = (rightAnswer + userVariant) / 2.0;
            var percentDifference = (absDifference / avg) * 100;

            var result = "";

            if (percentDifference > 100)
                result = "Ты оооочень сильно ошибаешься (=";
            else if (percentDifference > 75)
                result = "Ты очень сильно ошибаешься (=";
            else if (percentDifference > 50)
                result = "Ты сильно ошибаешься (=";
            else if (percentDifference > 25)
                result = "Уже лучше (=";
            else if (percentDifference > 12.5)
                result = "Ты близок к правильному ответу (=";
            else if (percentDifference > 6)
                result = "Почти, почти (=";
            else if (percentDifference > 3)
                result = "Ооочень близко! (=";
            else if (percentDifference == 0)
                result = "В точку! (=";
            else
            {
                result = String.Format("Почти верно. Ответ = {0}", rightAnswer);
            }

            Result_Label.Content = result;
        }

        private void Skip_Button_Click(object sender, RoutedEventArgs e)
        {
            AskQuestion();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.C)
                MessageBox.Show(String.Format("Ответ = {0}", rightAnswer), "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }





        //void DoGame()
        //{
        //    AskQuestion();
        //}
    }
}
