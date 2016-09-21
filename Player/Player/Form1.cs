using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files, paths;
        WMPLib.IWMPPlaylist playlist;

        bool firstRunWas = false;
        int indexChangeListBox;

        void AddSongs()
        {
            WMPLib.IWMPMedia media;

            //добавление песен в плей лист
            foreach (string file in openFileDialog1.FileNames)
            {
                media = MediaPlayer.newMedia(file);
                playlist.appendItem(media);
            }

            //создание списка в лист боксе
            files = openFileDialog1.SafeFileNames;
            paths = openFileDialog1.FileNames;
            for (int i = 0; i < files.Length; i++)
            {
                List.Items.Add(files[i]);
            }

        }


        private void Open_Click(object sender, EventArgs e)
        {
            if (!firstRunWas) //create play list songs
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //создание плейлиста
                    playlist = MediaPlayer.playlistCollection.newPlaylist("myPlayList");

                    AddSongs();

                    MediaPlayer.currentPlaylist = playlist;
                    MediaPlayer.Ctlcontrols.play();

                    firstRunWas = true;
                }
            }
            else //add song to play list
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    AddSongs();
                }
            }
        }

        private void PlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChangeListBox = List.SelectedIndex;

            // Get the currently selected item in the ListBox. 
            //string curItem = PlayerList.SelectedItem.ToString();
            //// надо убрать .mp3
            //curItem = curItem.Remove(curItem.Length - 5, 4);
            //string w;
            //for(int i =0; i < playlist.count; ++i )
            //{
            //    w = playlist.get_Item(i).name;
            //    if (w == curItem)
            //    {
            //        MediaPlayer.Ctlcontrols.stop();
            //    }
            //}
            // клик по пустому месту приводи к вылету ++++++
            //MediaPlayer.URL = paths[PlayerList.SelectedIndex];       
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // подсветка текущей песни
            WMPLib.IWMPMedia media = MediaPlayer.Ctlcontrols.currentItem;

            //int index = 0;
            //for(int i = 0; i < playlist.count; i++)
            //{
            //    var song = playlist.get_Item(i);
            //    if(media.name == song.name )
            //    {
            //        index = i;
            //    }
            //}
            //List.SetSelected(index, true);

            ////если остановилось воспроизведение, проиграть следующий трек
            //if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            //{
            //    // 0 трек
            //    if (PlayerList.SelectedIndex + 1 > files.Length) 
            //    {
            //        MediaPlayer.URL = paths[0];
            //    }
            //    // следующий трек
            //    else
            //    {
            //        MediaPlayer.URL = paths[PlayerList.SelectedIndex + 1];
            //    }
            //}
        }

        private void PlayerList_DoubleClick(object sender, EventArgs e)
        {
            if (List.Items.Count > 0)
            {
                //воспроизведение выбраного файла из списка
                WMPLib.IWMPMedia media = MediaPlayer.currentPlaylist.get_Item(List.SelectedIndex);
                MediaPlayer.Ctlcontrols.playItem(media);
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            if (List.Items.Count > 0) // очистка ListBox
            {
                List.Items.Clear();

                WMPLib.IWMPPlaylist delPlayList = MediaPlayer.playlistCollection.newPlaylist("DeletePlayList");
                MediaPlayer.currentPlaylist = delPlayList;

                firstRunWas = false;
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (List.Items.Count > 0) 
            {
                WMPLib.IWMPMedia media = playlist.get_Item(List.SelectedIndex);
                playlist.removeItem(media);

                List.Items.RemoveAt(List.SelectedIndex);
            }
        }

        private void List_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                PlayerList_DoubleClick(sender, e);
            }
            else if(e.KeyCode == Keys.Delete)
            {
                Del_Click(sender, e);
            }

        }



    }

}
