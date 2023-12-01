
using Android.Telecom;
using System;
using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Input;

namespace mycustomerloginapp
{
    public class ProductPageViewModel
    {
        public ObservableCollection<Items> Items { get; set; }

        public ObservableCollection<Items> CartItems { get; set; }

        public Items SelectedItem { get; set; }

        public ICommand Itemclick { get; set; }
        public ICommand CartItemclick { get; set; }
        public ProductPageViewModel(INavigation navigation)
        {
            Items = new ObservableCollection<Items>
            {
                new Items
                {
                    Picture="jerome.png",
                    instructorname="JEROME",
                    title = "Ariel Yoga",
                    DayOfWeek= "WEDNESDAY",
                    Date="12/11/2023",
                    Time="10",
                    Dur="60 mins",
                    Capacity = "15",
                    Price = "£15"
                },
                new Items
                {
                    Picture="muthu.png",
                    instructorname="MUTHU",
                    title = "COOL YOGA",
                    DayOfWeek= "SUNDAY",
                    Date="19/11/2023",
                    Time="16",
                    Dur="60 mins",
                    Capacity = "29",
                    Price = "£39"
                },
                new Items
                {
                    Picture="tharika.png",
                    instructorname="Tharika",
                    title = "CALM YOGA",
                    DayOfWeek= "TUESDAY",
                    Date="23/11/2023",
                    Time="20",
                    Dur="90 mins",
                    Capacity = "29",
                    Price = "£45"
                },
                new Items
                {
                    Picture="sowme.png",
                    instructorname="SOWME",
                    title = "COOL YOGA",
                    DayOfWeek= "WEDNESDAY",
                    Time="24/11/2023",
                    Dur="90 mins",
                    Capacity = "29",
                    Price = "£35"
                },

            };
            CartItems = new ObservableCollection<Items> { };
            Itemclick = new Command<Items>(executeitemclickcommand);
            CartItemclick = new Command<Items>(executeCartitemclickcommand);
            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeitemclickcommand(Items item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new DetailsPage(this));
        }

        async void executeCartitemclickcommand(Items item)
        {
            this.CartItems.Add(this.SelectedItem);
            await navigation.PushModalAsync(new CartPage(this));

        }
    }
}
