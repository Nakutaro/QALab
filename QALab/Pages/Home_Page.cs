using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALab.Pages
{
    public class Home_Page
    {
        public static string INPUT_LOGIN = "mailbox__login";
        public static string INPUT_PASSWORD = "mailbox__password";
        public static string BUTTON_LOGIN = "mailbox__auth__button";
        public static string BUTTON_START_SEND_MESSAGE = "//div[@class='b-sticky']//span[contains(text(),'Написать письмо')]";
        public static string INPUT_TO_SEND = "//div[@class='compose-head']//textarea[@data-original-name='To']";
        public static string INPUT_THEME_MESSAGE = "//input[@class='b-input']";
		public static string BUTTON_ACCEPT_NULL_DESCRITPION = "//button[@class='btn btn_stylish btn_main confirm-ok']/span[contains(text(),'Продолжить')]";
		public static string BUTTON_SEND_MESSAGE ="//div[@class='b-toolbar']//div[@data-name='send']//span[contains(text(),'Отправить')]";
        public static string LABEL_MESSAGE_SEND = "//div[@class='message-sent__title']";
    }
}
