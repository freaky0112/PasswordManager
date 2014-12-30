using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PasswordManager {
    public class Data {
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
            }
        }
    }
}