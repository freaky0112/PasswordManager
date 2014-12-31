//
//                       _oo0oo_
//                      o8888888o
//                      88" . "88
//                      (| -_- |)
//                      0\  =  /0
//                    ___/`---'\___
//                  .' \\|     |// '.
//                 / \\|||  :  |||// \
//                / _||||| -:- |||||- \
//               |   | \\\  -  /// |   |
//               | \_|  ''\---/''  |_/ |
//               \  .-\__  '-'  ___/-. /
//             ___'. .'  /--.--\  `. .'___
//          ."" '<  `.___\_<|>_/___.' >' "".
//         | | :  `- \`.;`\ _ /`;.`/ - ` : | |
//         \  \ `_.   \_ __\ /__ _/   .-` /  /
//     =====`-.____`.___ \_____/___.-`___.-'=====
//                       `=---='
//
//
//     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
//               佛祖保佑         永无BUG
//
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace PasswordManager.Desktop {
    public interface ITransacableObject {
        object ReadPropertyValue(PropertyInfo property);

        void SetPropertyValue(PropertyInfo property, object value);
    }
    public class Data : INotifyPropertyChanged {


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public Data() {
            Digits = 0;
        }

        private string _guid;
        /// <summary>
        /// GUID
        /// </summary>
        public string Guid {
            get {
                return _guid;
            }
            set {
                _guid = value;
            }
        }

        private string _website;
        /// <summary>
        /// 网站
        /// </summary>
        public string Website {
            get {
                return _website;
            }
            set {
                _website = value;
                this.NotifyPropertyChanged("Website");
            }
        }

        private string _account;
        /// <summary>
        /// 帐号
        /// </summary>
        public string Account {
            get {
                return _account;
            }
            set {
                _account = value;
                this.NotifyPropertyChanged("Account");
            }
        }

        private string _password;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password {
            get {
                return _password;
            }
            set {
                _password = value;
                this.NotifyPropertyChanged("Password");
            }
        }

        private DateTime _generateTime;
        /// <summary>
        /// 生成时间
        /// </summary>
        public DateTime GenerateTime {
            get {
                return _generateTime;
            }
            set {
                _generateTime = value;
                this.NotifyPropertyChanged("GenerateTime");
            }
        }

        private DateTime _modifyTime;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime {
            get {
                return _modifyTime;
            }
            set {
                _modifyTime = value;
                this.NotifyPropertyChanged("ModifyTime");
            }
        }

        private bool _upper;
        /// <summary>
        /// 是否启用大写字母
        /// </summary>
        public bool Upper {
            get {
                return _upper;
            }
            set {
                _upper = value;
                this.NotifyPropertyChanged("Upper");
            }
        }

        private bool _lower;
        /// <summary>
        /// 是否启用小写字母
        /// </summary>
        public bool Lower {
            get {
                return _lower;
            }
            set {
                _lower = value;
                this.NotifyPropertyChanged("Lower");
            }
        }

        private bool _number;
        /// <summary>
        /// 是否启用数字
        /// </summary>
        public bool Number {
            get {
                return _number;
            }
            set {
                _number = value;
                this.NotifyPropertyChanged("Number");
            }
        }

        private bool _special;
        /// <summary>
        /// 是否启用特殊字符
        /// </summary>
        public bool Special {
            get {
                return _special;
            }
            set {
                _special = value;
                this.NotifyPropertyChanged("Special");
            }
        }

        private string _specialCharacters;
        /// <summary>
        /// 特殊字符
        /// </summary>
        public string SpecialCharacters {
            get {
                return _specialCharacters;
            }
            set {
                _specialCharacters = value;
                this.NotifyPropertyChanged("SpecialCharacters");
            }
        }

        private int _digits;
        /// <summary>
        /// 密码位数
        /// </summary>
        public int Digits {
            get {
                return _digits;
            }
            set {
                _digits = value;
                this.NotifyPropertyChanged("Digits");
            }
        }
    }
}