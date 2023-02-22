using SuperChat.Core;
using SuperChat.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SuperChat.ViewModels
{
    class MainVM : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }



        /* Commands */

        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set { _selectedContact = value; OnPropertyChanged(); }
        }



        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
            
        }

        public MainVM()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();
            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";

            });

            Messages.Add(new MessageModel
            {
                Username = "Allison",
                UsernameColor = "#409aff",
                ImageSource = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fousamaranking.fandom.com%2Fwiki%2FBojji&psig=AOvVaw0g2raSh37m3VyE2gX8nsN4&ust=1676895950290000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCPDR5q3Kof0CFQAAAAAdAAAAABAE",
                Message = "Test this",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true

            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Allison",
                    UsernameColor = "#409aff",
                    ImageSource = "https://static.wikia.nocookie.net/ousamaranking/images/b/be/Bojji_2022_anime_intro.jpg/revision/latest?cb=20220427001856",
                    Message = "Test this",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false

                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Bunny",
                    UsernameColor = "#409aff",
                    ImageSource = "https://static.wikia.nocookie.net/ousamaranking/images/b/be/Bojji_2022_anime_intro.jpg/revision/latest?cb=20220427001856",
                    Message = "Test this",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                    

                });
            }

            Messages.Add(new MessageModel
            {
                Username = "Allison",
                UsernameColor = "#409aff",
                ImageSource = "https://static.wikia.nocookie.net/ousamaranking/images/b/be/Bojji_2022_anime_intro.jpg/revision/latest?cb=20220427001856",
                Message = "Last Message",
                Time = DateTime.Now,
                IsNativeOrigin = true,
                

            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    UserName = $"Allison {i}",
                    ImageSource = "https://static.wikia.nocookie.net/ousamaranking/images/b/be/Bojji_2022_anime_intro.jpg/revision/latest?cb=20220427001856",
                    Messages = Messages, 
                });

            }
        }
    }
}
