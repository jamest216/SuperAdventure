using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        /// <summary>
        /// hit points a creature has
        /// </summary>
        private int _currentHitPoints;

        /// <summary>
        /// sets the current hit points using the INotify prperty event handler
        /// </summary>
        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        /// <summary>
        /// Maxiumum HP the creature has
        /// </summary>
        public int MaximumHitPoints { get; set; }

        /// <summary>
        /// Sets a creature
        /// </summary>
        /// <param name="currentHitPoints">current HP of the creature</param>
        /// <param name="maximumHitPoints">Max HP the creature has</param>
        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
        
        /// <summary>
        /// event hander for if the property has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// shows if the properties have been changed
        /// </summary>
        /// <param name="name">new name of change</param>
        protected void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
