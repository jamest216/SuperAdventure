using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Engine
{
    public class PlayerQuest : INotifyPropertyChanged
    {
        /// <summary>
        /// details of the quest
        /// </summary>
        private Quest _details;

        /// <summary>
        /// if the quiest has been complted or not
        /// </summary>
        private bool _isCompleted;

        /// <summary>
        /// Details of the quest
        /// </summary>
        public Quest Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }

        /// <summary>
        /// is the quest completed
        /// </summary>
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value;
                OnPropertyChanged("IsCompleted");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// name of quest
        /// </summary>
        public string Name
        {
            get { return Details.Name; }
        }


        /// <summary>
        /// sets a player quest
        /// </summary>
        /// <param name="details">the details of the quest</param>
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
