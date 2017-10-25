using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase
{
    [Serializable]
    public class AccidentModel
    {
        string version = "";    //版
        string date1 = "";      //発行日
        string writer = "";     //発行者
        string date2 = "";      //発生日
        string date3 = "";      //対策日
        string status = "";     //対策状況
        string number = "";     //作番
        string date4 = "";      //引渡日
        string name = "";       //プロジェクト名
        string customer = "";   //納先
        string pm = "";         //PM
        string pl = "";         //PL
        string dateTime1 = "";  //発生日時
        string person1 = "";    //発生対応者
        string detail1 = "";    //発生詳細
        string dateTime2 = "";  //発覚日時
        string person2 = "";    //発覚対応者
        string detail2 = "";    //発覚詳細
        string dateTime3 = "";  //調査開始日時
        string person3 = "";    //調査開始対応者
        string detail3 = "";    //調査開始詳細
        string dateTime4 = "";  //調査完日時
        string person4 = "";    //調査完対応者
        string detail4 = "";    //調査完詳細
        string dateTime5 = "";  //仮対策完日時
        string person5 = "";    //仮対策完対応者
        string detail5 = "";    //仮対策完詳細
        string dateTime6 = "";  //本対策完日時
        string person6 = "";    //本対策完対応者
        string detail6 = "";    //本対策完詳細
        string description = "";//現象
        string impact = "";     //業務影響
        string result = "";     //調査結果
        string tempFix = "";    //仮対策内容
        string fainalFix = "";  //本対策内容
        string cost = "";       //費用

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string Date1
        {
            get
            {
                return date1;
            }

            set
            {
                date1 = value;
            }
        }

        public string Writer
        {
            get
            {
                return writer;
            }

            set
            {
                writer = value;
            }
        }

        public string Date2
        {
            get
            {
                return date2;
            }

            set
            {
                date2 = value;
            }
        }

        public string Date3
        {
            get
            {
                return date3;
            }

            set
            {
                date3 = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Date4
        {
            get
            {
                return date4;
            }

            set
            {
                date4 = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public string Pm
        {
            get
            {
                return pm;
            }

            set
            {
                pm = value;
            }
        }

        public string Pl
        {
            get
            {
                return pl;
            }

            set
            {
                pl = value;
            }
        }

        public string DateTime1
        {
            get
            {
                return dateTime1;
            }

            set
            {
                dateTime1 = value;
            }
        }

        public string Person1
        {
            get
            {
                return person1;
            }

            set
            {
                person1 = value;
            }
        }

        public string Detail1
        {
            get
            {
                return detail1;
            }

            set
            {
                detail1 = value;
            }
        }

        public string DateTime2
        {
            get
            {
                return dateTime2;
            }

            set
            {
                dateTime2 = value;
            }
        }

        public string Person2
        {
            get
            {
                return person2;
            }

            set
            {
                person2 = value;
            }
        }

        public string Detail2
        {
            get
            {
                return detail2;
            }

            set
            {
                detail2 = value;
            }
        }

        public string DateTime3
        {
            get
            {
                return dateTime3;
            }

            set
            {
                dateTime3 = value;
            }
        }

        public string Person3
        {
            get
            {
                return person3;
            }

            set
            {
                person3 = value;
            }
        }

        public string Detail3
        {
            get
            {
                return detail3;
            }

            set
            {
                detail3 = value;
            }
        }

        public string DateTime4
        {
            get
            {
                return dateTime4;
            }

            set
            {
                dateTime4 = value;
            }
        }

        public string Person4
        {
            get
            {
                return person4;
            }

            set
            {
                person4 = value;
            }
        }

        public string Detail4
        {
            get
            {
                return detail4;
            }

            set
            {
                detail4 = value;
            }
        }

        public string DateTime5
        {
            get
            {
                return dateTime5;
            }

            set
            {
                dateTime5 = value;
            }
        }

        public string Person5
        {
            get
            {
                return person5;
            }

            set
            {
                person5 = value;
            }
        }

        public string Detail5
        {
            get
            {
                return detail5;
            }

            set
            {
                detail5 = value;
            }
        }

        public string DateTime6
        {
            get
            {
                return dateTime6;
            }

            set
            {
                dateTime6 = value;
            }
        }

        public string Person6
        {
            get
            {
                return person6;
            }

            set
            {
                person6 = value;
            }
        }

        public string Detail6
        {
            get
            {
                return detail6;
            }

            set
            {
                detail6 = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Impact
        {
            get
            {
                return impact;
            }

            set
            {
                impact = value;
            }
        }

        public string Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public string TempFix
        {
            get
            {
                return tempFix;
            }

            set
            {
                tempFix = value;
            }
        }

        public string FainalFix
        {
            get
            {
                return fainalFix;
            }

            set
            {
                fainalFix = value;
            }
        }

        public string Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public AccidentModel()
        {
        }


    }
}
