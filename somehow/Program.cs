using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace somehow
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var url = "https://broker.msa.apps.yokogawa.dev/resources/AloxyResourceTest/series/temperature?from=1631712298000&untill=1631712298000&aggregates=mean&grouping=day";
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6ImIwMzY1OGNiLTk3MDMtNDBhNC1iMWFhLTczYzBkODhhODU2NiJ9.eyJ0ZW5hbnQiOiJiMDM2NThjYi05NzAzLTQwYTQtYjFhYS03M2MwZDg4YTg1NjYiLCJsaWNlbnNlcyI6WyJyYmFjIiwidHNhbmFseXRpY3MiXSwiZXhwIjoxNjMxOTA0NjA5LCJkb21haW4iOiJ5ZHgubXNhLmFwcHMueW9rb2dhd2EuZGV2IiwiZ3JvdXBzIjpbXSwicGVybWlzc2lvbnMiOlsibG9nczphbGw6Y3J1ZCIsImxvZ3M6bWU6Y3J1ZCIsImJ1Y2tldG9iamVjdDphbGw6YyIsInRhc2tzOm1lOmNydWQiLCJ0YXNrczphbGw6Y3J1ZCIsInJlc291cmNlczptZTpjcnVkIiwicmVzb3VyY2VzOmFsbDpjcnVkIiwicGx1Z3M6bWU6Y3J1ZCIsInBsdWdzOmFsbDpjcnVkIiwidGVtcGxhdGVzOm1lOmNydWQiLCJ0ZW1wbGF0ZXM6YWxsOmNydWQiLCJhbGFybXM6bWU6Y3J1ZCIsImFsYXJtczphbGw6Y3J1ZCIsInNldHRpbmdzOm1lOmNydWQiLCJzZXR0aW5nczphbGw6Y3J1ZCIsIm1pZ3JhdGlvbjptZTpjcnVkIiwibWlncmF0aW9uOmFsbDpjcnVkIiwibWVhc3VyZW1lbnRzOm1lOmNydWQiLCJtZWFzdXJlbWVudHM6YWxsOmNydWQiLCJiaWxsaW5nOm1lOmNydWQiLCJiaWxsaW5nOmFsbDpjcnVkIiwiZXhwb3J0Om1lOmNydWQiLCJleHBvcnQ6YWxsOmNydWQiLCJ0b2tlbnM6bWU6Y3J1ZCIsInRva2VuczphbGw6Y3J1ZCIsImpvYnM6bWU6Y3J1ZCIsImpvYnM6YWxsOmNydWQiLCJ2YXVsdDptZTpjcnVkIiwidmF1bHQ6YWxsOmNydWQiLCJ1c2VyczphbGw6Y3J1ZCIsInJvbGVzOmFsbDpjcnVkIiwib3JnYW5pc2F0aW9uczptZTpjcnVkIiwib3JnYW5pc2F0aW9uczphbGw6Y3J1ZCIsImJ5b21sOm1lOmNydWQiLCJieW9tbDphbGw6Y3J1ZCJdLCJpYXQiOjE2MzE4NjE0MDksImlzcyI6IkB3YXlsYXkvYXV0aCIsInN1YiI6InVzZXJzLzg1NzYwYTNjLTg3NzUtNDM1My1hMDA1LTRlZDg0NzdhODgyZSJ9.YeacfXLxo-GLQf3MC2IDvvXP6Ysac0wxEAOVA91md9KoOHu4YtqIX_Lemqn70hsbX7y3gy0GYus_R3uePYj_lhLVsV_Ctc-5sh48YFFQA2N5e7Xm__2qb1JK5g0_cTdVhHXa2UJMaPe1drecZTWntIrMac_7Gboe8mlsGYltL0g0Q0oZXPZwaa1454n9EM45LeD4wpk658iIXjZ2XOLGF0F-i5xQUvE8LXSi2IS2yo3oDocTY3U5-ql2ZPVfl2YTroNTDpp6RryXvKQfPTiV66SyopYnDZLs0w2bhZvMANbE_auSiORKL6IkC67azbD1vMM9-TCTSzpGtoEEi03J4g");

            var response = client.GetStringAsync(url);
            File.WriteAllText("WriteText.txt", response.Result);
            Console.WriteLine(response.Result);
        }
    }
}
