using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NganHang.Validation
{
    public class MyRegex
    {
        private const string regexSurname = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s\W|_]{1,50}$";
        private const string regexName = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s\W|_]{1,10}$";
        private const string regexCMND = "^(?:[0-9]{9})";
        private const string regexSDT = "^(?:[0-9]{10,15})";

        private const string hasNumber = @"[0-9]+";
        private const string hasUpperChar = @"[A-Z]+";
        private const string hasMinimum8Chars = @".{8,}";

        public static string RegexSurname => regexSurname;

        public static string RegexName => regexName;

        public static string RegexCMND => regexCMND;

        public static string RegexSDT => regexSDT;

        public static bool ValidateSurname(string surname)
        {
            if (!Regex.Match(surname.Trim(), MyRegex.regexSurname).Success)
            {
                MessageBox.Show("Họ phải là chữ, tối đa 50 kí tự và không được để trống.", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool ValidateName(string name)
        {
            if (!Regex.Match(name.Trim(), MyRegex.RegexName).Success)
            {
                MessageBox.Show("Tên phải là chữ, tối đa 10 kí tự và không được để trống.", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool ValidateCMND(string CMND)
        {
            if (!Regex.Match(CMND.Trim(), MyRegex.RegexCMND).Success)
            {
                MessageBox.Show("CMND phải có 9 số.", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool ValidateAddress(string address)
        {
            if (address.Trim().Length == 0 || address.Trim().Length > 100)
            {
                MessageBox.Show("Địa chỉ phải từ 1->100 kí tự.", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (!Regex.Match(phoneNumber.Trim(), MyRegex.RegexSDT).Success)
            {
                MessageBox.Show("Số điện thoại phải có 10 số.", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool ValidatePassword(string password)
        {
            if (password.Contains(" ") || password.Contains("\\t"))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng cách", "", MessageBoxButtons.OK);
                return false;
            }
            if (!Regex.Match(password.Trim(), MyRegex.hasMinimum8Chars).Success ||
                !Regex.Match(password.Trim(), MyRegex.hasNumber).Success ||
                !Regex.Match(password.Trim(), MyRegex.hasUpperChar).Success)
            {
                MessageBox.Show("Mật khẩu phải có 8 kí tự bao gồm cả số và chữ in hoa.", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool ValidateLoginName(string loginName)
        {
            if (loginName.Contains(" ") || loginName.Contains("\\t"))
            {
                MessageBox.Show("Tài khoản không được chứa khoảng cách", "", MessageBoxButtons.OK);
                return false;
            }
            if (loginName.Trim().Length <6 || loginName.Trim().Length > 50)
            {
                MessageBox.Show("Tài khoản phải có từ 6->50 kí tự.", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
