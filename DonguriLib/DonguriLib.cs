using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace DonguriLib
{
    public class DonguriLib

    {

        public class TCode
        {
            public TCode() { }
            public int CodeId { get; set; } // コード種別
            public int Id { get; set; } // コードID
            public string Value { get; set; } // 値
        }

        public class TCalender
        {
            public TCalender() { }
            public DateTime Target { get; set; } // 
            public string Item { get; set; } // 
            public string Note { get; set; } // 
            public int TypeId { get; set; } // 
        }

        public class THelper
        {
            public THelper() { }
            public int Id { get; set; } // ヘルパーID
            public string FamilyName { get; set; } // 名前
            public string FirstName { get; set; } // 名前
            public string SecondName { get; set; } // 名前
            public string ThirdName { get; set; } // 名前
            public DateTime Birthday { get; set; } // 誕生日
            public int SexId { get; set; } // 性別ID
            public int Member { get; set; } // 従属数
            public int StatusId { get; set; } // 状態ID
        }

        public class THelperSlave
        {
            public THelperSlave() { }
            public int Id { get; set; } // ヘルパーID
            public int SlaveId { get; set; } // 従属ヘルパーID
            public int AccountMag { get; set; } // 課金情報
        }

        public class TSchedule
        {
            public TSchedule() { }
            public int UserId { get; set; } // ユーザーID
            public int HelperId { get; set; } // ヘルパーID
            public int JobId { get; set; } // 業務ID
            public int TypeId { get; set; } // 種類ID
            public DateTime Target { get; set; } // 対象日
            public DateTime FromTime { get; set; } // 開始時刻
            public DateTime ToTime { get; set; } // 終了時刻
            public string  ViewNote { get; set; } // 公開メモ
            public string HideNote { get; set; } // 非公開メモ
            public int Attention { get; set; } // 
            public int IsCancel { get; set; } // 
        }

        public class TUser
        {
            public TUser() { }
            public int Id { get; set; } // 利用者番号
            public string FamilyName { get; set; } // 名前
            public string FirstName { get; set; } // 名前
            public string SecondName { get; set; } // 名前
            public string ThirdName { get; set; } // 名前
            public DateTime Birthday { get; set; } // 誕生日
            public int SexId { get; set; } // 性別ID
            public int StatusId { get; set; } // 状態ID
        }


        public class TUserUpper
        {
            public TUserUpper() { }
            public int Id { get; set; } // 利用者番号
            public DateTime FromDate { get; set; } // 適用開始日
            public Decimal Sin { get; set; } // 身体上限
            public Decimal Kaj { get; set; } // 家事上限
            public Decimal Ido { get; set; } // 移動上限
            public Decimal Tsu { get; set; } // 通院上限
        }

        public static void CreateDatabase()
        {
            if(!File.Exists(Properties.Settings.Default.DataFile))
            {
                SQLiteConnection.CreateFile(Properties.Settings.Default.DataFile);
            }
             
            // データベースへ接続
            using (var cn = new SQLiteConnection(Properties.Settings.Default.DataFile))
            {
                // テーブルの作成
                connection.CreateTable<TCode>();
                connection.CreateTable<TCalender>();
                connection.CreateTable<THelper>();
                connection.CreateTable<THelperSlave>();
                connection.CreateTable<TSchedule>();
                connection.CreateTable<TUser>();
                connection.CreateTable<TUserUpper>();
            }

   



        }
    }

}
