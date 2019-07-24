using GenericServices;
using MoneyFox.Application.Interfaces.Mapping;
using MoneyFox.Domain.Entities;

namespace MoneyFox.Presentation.ViewModels
{
    public class CategoryViewModel : BaseViewModel, ILinkToEntity<Category>, IMapFrom<Category>
    {
        private int id;
        private string name;
        private string note;

        public int Id
        {
            get => id;
            set
            {
                if (id == value) return;
                id = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (name == value) return;
                name = value;
                RaisePropertyChanged();
            }
        }


        /// <summary>
        ///     Additional details about the CategoryViewModel
        /// </summary>
        public string Note
        {
            get => note;
            set
            {
                if (note == value) return;
                note = value;
                RaisePropertyChanged();
            }
        }
    }
}