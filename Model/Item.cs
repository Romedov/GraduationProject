using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Runtime.CompilerServices;
using System.Windows;
using GraduationProject.Model;

namespace GraduationProject
{

    public partial class Item : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        public static event EventHandler<ItemSearchEventArgs> ItemSearching;
        #endregion
        #region Private fields
        [NotMapped]
        private long _number;
        #endregion
        #region Public properties
        [Key]
        [StringLength(50)]
        public string IId { get; private set; }

        [Required]
        [StringLength(100)]
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public long Number
        {
            get { return _number; }
            set { _number = value; OnPropertyChanged(); }
        }

        public int Discount { get; private set; }

        #endregion
        #region Methods
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public static Item GetItem(object sender, string iId)
        {
            using (CashboxModel db = new CashboxModel())
            {
                Item item = null;
                try
                {
                    db.DBConnectionCheck();
                    item = db.Items.FirstOrDefault(i => i.IId == iId);
                    if (item != null)
                    {
                        ItemSearching?.Invoke(sender, new ItemSearchEventArgs($"����� � ��������������� {iId} �������� � ���!", true));
                        return item;
                    }
                    else
                    {
                        ItemSearching?.Invoke(sender, new ItemSearchEventArgs($"����� � ��������������� {iId} � ���� ������ �� ���������������!", false));
                        return null;
                    }

                }
                catch(Exception e)
                {
                    ItemSearching?.Invoke(sender, new ItemSearchEventArgs($"�� ������� ����� ����� � ���� ������!/n{e.Message}", false));
                    return null;
                }
            }
        }
        public bool SellItem()
        {
            try
            {
                Item itemSold = null;
                using(CashboxModel db = new CashboxModel())
                {
                    db.DBConnectionCheck();
                    long currShiftId = db.Shifts.OrderByDescending(sh => sh.SId).Select(sh => sh.SId).FirstOrDefault();
                    //�������� �� ������������� ������� ����� ������ � ������� �����
                    //���������� ������� ����� ��� ����������, ���� ���������� ����������� ��� �������
                }
            }
            catch (Exception e)
            {

            }
        }
        #endregion
    }
}
