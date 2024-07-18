using Microsoft.Win32;
using NAudio.Wave;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace MusicPlayer
{
    public partial class MainWindow : Window
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private string selectedFilePath;
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            LoadMusicFiles(@"E:\000Task\WPF\MusicPlayer\MusicPlayer\Music");
            random = new Random();
        }

        private void LoadMusicFiles(string musicFolderPath)
        {
            if (!Directory.Exists(musicFolderPath))
            {
                MessageBox.Show("Указанная папка не существует.");
                return;
            }

            var mp3Files = Directory.GetFiles(musicFolderPath, "*.mp3");
            if (mp3Files.Length == 0)
            {
                MessageBox.Show("В папке нет MP3 файлов.");
                return;
            }

            foreach (var file in mp3Files)
            {
                string fileName = System.IO.Path.GetFileName(file); 
                listBoxSongs.Items.Add(new ListBoxItem { Content = fileName, Tag = file });
            }
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            PlaySelectedFile();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            waveOutDevice?.Pause();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            waveOutDevice?.Stop();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                string fileName = System.IO.Path.GetFileName(filePath); 
                listBoxSongs.Items.Add(new ListBoxItem { Content = fileName, Tag = filePath });
            }
        }

        private void ListBoxSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlaySelectedFile();
        }

        private void PlaySelectedFile()
        {
            if (listBoxSongs.SelectedItem != null)
            {
                var selectedItem = listBoxSongs.SelectedItem as ListBoxItem;
                selectedFilePath = selectedItem.Tag.ToString();

                try
                {
                    waveOutDevice?.Stop();
                    waveOutDevice?.Dispose();
                    audioFileReader?.Dispose();

                    waveOutDevice = new WaveOutEvent();
                    audioFileReader = new AudioFileReader(selectedFilePath);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка воспроизведения файла: {ex.Message}");
                }
            }
        }

        private void BtnRandom_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxSongs.Items.Count > 0)
            {
                int index = random.Next(0, listBoxSongs.Items.Count);
                listBoxSongs.SelectedIndex = index;
                PlaySelectedFile();
            }
        }
    }
}
