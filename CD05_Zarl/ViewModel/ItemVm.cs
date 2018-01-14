using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CD05_Zarl.ViewModel
{
    public class ItemVm : ViewModelBase
    {
        public string Description { get; set; }
        public BitmapImage Image { get; set; }
        public ObservableCollection<ItemVm> Items { get; set; }
        public string AgeRecommendation { get; set; }

        public int NoOfParts
        {
            get
            {
                if (Items != null)
                {
                    return Items.Count;
                }
                else return 0;

            }
        }


        public ItemVm(string description, BitmapImage image, string age)
        {
            Description = description;
            Image = image;
            this.AgeRecommendation = age;
        }

        public void AddItem(ItemVm item)
        {
            if (Items == null)
            { 
                Items = new ObservableCollection<ItemVm>();
            }

            Items.Add(item);
        }

    }
}
