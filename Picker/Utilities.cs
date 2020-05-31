namespace Picker
{
    using System;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;

    // @formatter:off
    public enum Country
    {
        [Description("ABD Virgin Adaları")] VI,
        [Description("Afganistan")] AF,
        [Description("Aland Adaları")] AX,
        [Description("Almanya")] DE,
        [Description("Amerika Birleşik Devletleri")] US,
        [Description("Amerika Birleşik Devletleri Küçük Dış Adaları")] UM,
        [Description("Amerikan Samoası")] AS,
        [Description("Andora")] AD,
        [Description("Angola")] AO,
        [Description("Anguilla")] AI,
        [Description("Antarktika")] AQ,
        [Description("Antigua ve Barbuda")] AG,
        [Description("Arjantin")] AR,
        [Description("Arnavutluk")] AL,
        [Description("Aruba")] AW,
        [Description("Avrupa Birliği")] QU,
        [Description("Avustralya")] AU,
        [Description("Avusturya")] AT,
        [Description("Azerbaycan")] AZ,
        [Description("Bahamalar")] BS,
        [Description("Bahreyn")] BH,
        [Description("Bangladeş")] BD,
        [Description("Barbados")] BB,
        [Description("Batı Sahara")] EH,
        [Description("Belize")] BZ,
        [Description("Belçika")] BE,
        [Description("Benin")] BJ,
        [Description("Bermuda")] BM,
        [Description("Beyaz Rusya")] BY,
        [Description("Bhutan")] BT,
        [Description("Birleşik Arap Emirlikleri")] AE,
        [Description("Birleşik Krallık")] GB,
        [Description("Bolivya")] BO,
        [Description("Bosna Hersek")] BA,
        [Description("Botsvana")] BW,
        [Description("Bouvet Adası")] BV,
        [Description("Brezilya")] BR,
        [Description("Brunei")] BN,
        [Description("Bulgaristan")] BG,
        [Description("Burkina Faso")] BF,
        [Description("Burundi")] BI,
        [Description("Cape Verde")] CV,
        [Description("Cebelitarık")] GI,
        [Description("Cezayir")] DZ,
        [Description("Christmas Adası")] CX,
        [Description("Cibuti")] DJ,
        [Description("Cocos Adaları")] CC,
        [Description("Cook Adaları")] CK,
        [Description("Çad")] TD,
        [Description("Çek Cumhuriyeti")] CZ,
        [Description("Çin")] CN,
        [Description("Danimarka")] DK,
        [Description("Dominik")] DM,
        [Description("Dominik Cumhuriyeti")] DO,
        [Description("Doğu Timor")] TL,
        [Description("Ekvator")] EC,
        [Description("Ekvator Ginesi")] GQ,
        [Description("El Salvador")] SV,
        [Description("Endonezya")] ID,
        [Description("Eritre")] ER,
        [Description("Ermenistan")] AM,
        [Description("Estonya")] EE,
        [Description("Etiyopya")] ET,
        [Description("Falkland Adaları (Malvinalar)")] FK,
        [Description("Faroe Adaları")] FO,
        [Description("Fas")] MA,
        [Description("Fiji")] FJ,
        [Description("Fildişi Sahilleri")] CI,
        [Description("Filipinler")] PH,
        [Description("Filistin Bölgesi")] PS,
        [Description("Finlandiya")] FI,
        [Description("Fransa")] FR,
        [Description("Fransız Guyanası")] GF,
        [Description("Fransız Güney Bölgeleri")] TF,
        [Description("Fransız Polinezyası")] PF,
        [Description("Gabon")] GA,
        [Description("Gambia")] GM,
        [Description("Gana")] GH,
        [Description("Gine")] GN,
        [Description("Gine-Bissau")] GW,
        [Description("Granada")] GD,
        [Description("Grönland")] GL,
        [Description("Guadeloupe")] GP,
        [Description("Guam")] GU,
        [Description("Guatemala")] GT,
        [Description("Guernsey")] GG,
        [Description("Guyana")] GY,
        [Description("Güney Afrika")] ZA,
        [Description("Güney Georgia ve Güney Sandwich Adaları")] GS,
        [Description("Güney Kore")] KR,
        [Description("Güney Kıbrıs Rum Kesimi")] CY,
        [Description("Gürcistan")] GE,
        [Description("Haiti")] HT,
        [Description("Heard Adası ve McDonald Adaları")] HM,
        [Description("Hindistan")] IN,
        [Description("Hint Okyanusu İngiliz Bölgesi")] IO,
        [Description("Hollanda")] NL,
        [Description("Hollanda Antilleri")] AN,
        [Description("Honduras")] HN,
        [Description("Hong Kong SAR - Çin")] HK,
        [Description("Hırvatistan")] HR,
        [Description("Irak")] IQ,
        [Description("İngiliz Virgin Adaları")] VG,
        [Description("İran")] IR,
        [Description("İrlanda")] IE,
        [Description("İspanya")] ES,
        [Description("İsrail")] IL,
        [Description("İsveç")] SE,
        [Description("İsviçre")] CH,
        [Description("İtalya")] IT,
        [Description("İzlanda")] IS,
        [Description("Jamaika")] JM,
        [Description("Japonya")] JP,
        [Description("Jersey")] JE,
        [Description("Kamboçya")] KH,
        [Description("Kamerun")] CM,
        [Description("Kanada")] CA,
        [Description("Karadağ")] ME,
        [Description("Katar")] QA,
        [Description("Kayman Adaları")] KY,
        [Description("Kazakistan")] KZ,
        [Description("Kenya")] KE,
        [Description("Kiribati")] KI,
        [Description("Kolombiya")] CO,
        [Description("Komorlar")] KM,
        [Description("Kongo")] CG,
        [Description("Kongo Demokratik Cumhuriyeti")] CD,
        [Description("Kosta Rika")] CR,
        [Description("Kuveyt")] KW,
        [Description("Kuzey Kore")] KP,
        [Description("Kuzey Mariana Adaları")] MP,
        [Description("Küba")] CU,
        [Description("Kırgızistan")] KG,
        [Description("Laos")] LA,
        [Description("Lesotho")] LS,
        [Description("Letonya")] LV,
        [Description("Liberya")] LR,
        [Description("Libya")] LY,
        [Description("Liechtenstein")] LI,
        [Description("Litvanya")] LT,
        [Description("Lübnan")] LB,
        [Description("Lüksemburg")] LU,
        [Description("Macaristan")] HU,
        [Description("Madagaskar")] MG,
        [Description("Makao S.A.R. Çin")] MO,
        [Description("Makedonya")] MK,
        [Description("Malavi")] MW,
        [Description("Maldivler")] MV,
        [Description("Malezya")] MY,
        [Description("Mali")] ML,
        [Description("Malta")] MT,
        [Description("Man Adası")] IM,
        [Description("Marshall Adaları")] MH,
        [Description("Martinik")] MQ,
        [Description("Mauritius")] MU,
        [Description("Mayotte")] YT,
        [Description("Meksika")] MX,
        [Description("Mikronezya Federal Eyaletleri")] FM,
        [Description("Moldovya Cumhuriyeti")] MD,
        [Description("Monako")] MC,
        [Description("Montserrat")] MS,
        [Description("Moritanya")] MR,
        [Description("Mozambik")] MZ,
        [Description("Moğolistan")] MN,
        [Description("Myanmar")] MM,
        [Description("Mısır")] EG,
        [Description("Namibya")] NA,
        [Description("Nauru")] NR,
        [Description("Nepal")] NP,
        [Description("Nijer")] NE,
        [Description("Nijerya")] NG,
        [Description("Nikaragua")] NI,
        [Description("Niue")] NU,
        [Description("Norfolk Adası")] NF,
        [Description("Norveç")] NO,
        [Description("Orta Afrika Cumhuriyeti")] CF,
        [Description("Özbekistan")] UZ,
        [Description("Pakistan")] PK,
        [Description("Palau")] PW,
        [Description("Panama")] PA,
        [Description("Papua Yeni Gine")] PG,
        [Description("Paraguay")] PY,
        [Description("Peru")] PE,
        [Description("Pitcairn")] PN,
        [Description("Polonya")] PL,
        [Description("Portekiz")] PT,
        [Description("Porto Riko")] PR,
        [Description("Reunion")] RE,
        [Description("Romanya")] RO,
        [Description("Ruanda")] RW,
        [Description("Rusya Federasyonu")] RU,
        [Description("Saint Helena")] SH,
        [Description("Saint Kitts ve Nevis")] KN,
        [Description("Saint Lucia")] LC,
        [Description("Saint Pierre ve Miquelon")] PM,
        [Description("Saint Vincent ve Grenadinler")] VC,
        [Description("Samoa")] WS,
        [Description("San Marino")] SM,
        [Description("Sao Tome ve Principe")] ST,
        [Description("Senegal")] SN,
        [Description("Seyşeller")] SC,
        [Description("Sierra Leone")] SL,
        [Description("Singapur")] SG,
        [Description("Slovakya")] SK,
        [Description("Slovenya")] SI,
        [Description("Solomon Adaları")] SB,
        [Description("Somali")] SO,
        [Description("Sri Lanka")] LK,
        [Description("Sudan")] SD,
        [Description("Surinam")] SR,
        [Description("Suriye")] SY,
        [Description("Suudi Arabistan")] SA,
        [Description("Svalbard ve Jan Mayen")] SJ,
        [Description("Svaziland")] SZ,
        [Description("Sırbistan")] RS,
        [Description("Sırbistan-Karadağ")] CS,
        [Description("Şili")] CL,
        [Description("Tacikistan")] TJ,
        [Description("Tanzanya")] TZ,
        [Description("Tayland")] TH,
        [Description("Tayvan")] TW,
        [Description("Togo")] TG,
        [Description("Tokelau")] TK,
        [Description("Tonga")] TO,
        [Description("Trinidad ve Tobago")] TT,
        [Description("Tunus")] TN,
        [Description("Turks ve Caicos Adaları")] TC,
        [Description("Tuvalu")] TV,
        [Description("Türkiye")] TR,
        [Description("Türkmenistan")] TM,
        [Description("Uganda")] UG,
        [Description("Ukrayna")] UA,
        [Description("Umman")] OM,
        [Description("Uruguay")] UY,
        [Description("Uzak Okyanusya")] QO,
        [Description("Ürdün")] JO,
        [Description("Vanuatu")] VU,
        [Description("Vatikan")] VA,
        [Description("Venezuela")] VE,
        [Description("Vietnam")] VN,
        [Description("Wallis ve Futuna")] WF,
        [Description("Yemen")] YE,
        [Description("Yeni Kaledonya")] NC,
        [Description("Yeni Zelanda")] NZ,
        [Description("Yunanistan")] GR,
        [Description("Zambiya")] ZM,
        [Description("Zimbabve")] ZW
    }
    // @formatter:on

    public static class Utilities
    {
        public const string ImagePathFormat = @"assets\{0}\{1}.png";

        public static void CheckAssets()
        {
            Directory.CreateDirectory(@"assets\brands");
            Directory.CreateDirectory(@"assets\builds");
            Directory.CreateDirectory(@"assets\chipsets");
            Directory.CreateDirectory(@"assets\graphics");
            Directory.CreateDirectory(@"assets\memories");
            Directory.CreateDirectory(@"assets\motherboards");
            Directory.CreateDirectory(@"assets\processors");
            Directory.CreateDirectory(@"assets\sockets");
        }

        public static bool CheckDatabase()
        {
            try
            {
                using var context = new ComputerDatabaseContext();

                if (!context.Database.Exists())
                {
                    RecursiveDelete("assets");
                    context.Database.Create();
                }
                else if (!context.Database.CompatibleWithModel(false))
                {
                    var result = ShowError(
                        "Mevcut veri tabanı eski ve programda kullanılan modelle uyuşmuyor.\r\n" +
                        "Yeni bir veri tabanı oluşturmak için eski veri tabanı silinsin mi?",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                        return false;

                    RecursiveDelete("assets");
                    context.Database.Delete();
                    context.Database.Create();
                }

                return true;
            }
            catch (SqlException e) when (e.Number == 3702)
            {
                ShowError("Veri tabanı şu anda kullanıldığı için silinemiyor. " +
                          "Diğer bağlantıları kapattıktan sonra veri tabanını silin.");

                return false;
            }
        }

        public static void Clear(this Control.ControlCollection controls, bool dispose)
        {
            for (var ix = controls.Count - 1; ix >= 0; --ix)
                if (dispose)
                    controls[ix].Dispose();
                else
                    controls.RemoveAt(ix);
        }

        public static void RecursiveDelete(string directoryPath)
            => new DirectoryInfo(directoryPath).RecursiveDelete();

        public static void RecursiveDelete(this DirectoryInfo directoryInfo)
        {
            if (!directoryInfo.Exists)
                return;

            foreach (var subDirectoryInfo in directoryInfo.EnumerateDirectories())
                subDirectoryInfo.RecursiveDelete();

            directoryInfo.Delete(true);
        }

        public static TValue GetAttributeValue<TAttribute, TValue>(this Type type,
            Func<TAttribute, TValue> valueSelector)
            where TAttribute : Attribute
        {
            var customAttributes = type.GetCustomAttributes(typeof(TAttribute), true);

            if (customAttributes.FirstOrDefault() is TAttribute att)
                return valueSelector(att);

            return default;
        }

        public static string GetCopyright()
            => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location)
                .LegalCopyright;

        public static string GetDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo == null)
                return description;

            var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (attrs.Length > 0)
                description = ((DescriptionAttribute)attrs[0]).Description;

            return description;
        }

        public static int GetPumpRate(string memoryType)
            => memoryType != null
                ? memoryType.ToUpper() switch
                {
                    "SDR" => 1,
                    "HBM" => 2,
                    "HBM2" => 2,
                    "DDR" => 2,
                    "DDR2" => 2,
                    "DDR3" => 2,
                    "DDR4" => 2,
                    "GDDR" => 2,
                    "GDDR2" => 2,
                    "GDDR3" => 2,
                    "GDDR4" => 2,
                    "GDDR5" => 4,
                    "GDDR5X" => 8,
                    "GDDR6" => 8,
                    _ => throw new ArgumentException(nameof(memoryType))
                }
                : throw new ArgumentNullException(nameof(memoryType));

        public static string GetVersionString()
            => Assembly.GetExecutingAssembly().GetName().Version.GetVersionString();

        public static string GetVersionString(this Version version)
        {
            if (version.Build == -1)
                return version.ToString(version.Minor == 0 ? 1 : 2);

            if (version.Revision != -1 && version.Revision != 0)
                return version.ToString(4);

            return version.Build != 0
                ? version.ToString(3)
                : version.ToString(version.Minor == 0 ? 1 : 2);
        }

        public static Image LoadImage(string imagePath)
        {
            using var bitmap = new Bitmap(imagePath);
            return new Bitmap(bitmap);
        }

        public static void ShowError(string text) => ShowError(text, MessageBoxButtons.OK);

        public static DialogResult ShowError(string text, MessageBoxButtons buttons)
            => MessageBox.Show(text, "Hata", buttons, MessageBoxIcon.Error);

        public static void ShowInformation(string text)
            => ShowInformation(text, MessageBoxButtons.OK);

        public static DialogResult ShowInformation(string text, MessageBoxButtons buttons)
            => MessageBox.Show(text, "Bilgi", buttons, MessageBoxIcon.Information);

        public static void ShowWarning(string text) => ShowWarning(text, MessageBoxButtons.OK);

        public static DialogResult ShowWarning(string text, MessageBoxButtons buttons)
            => MessageBox.Show(text, "Uyarı", buttons, MessageBoxIcon.Warning);

        public static string ToTitleCase(this string str)
            => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
    }
}

namespace System
{
    using Threading.Tasks;

    /// <summary>Provides a mechanism for releasing unmanaged resources asynchronously.</summary>
    internal interface IAsyncDisposable
    {
        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or
        ///     resetting unmanaged resources asynchronously.
        /// </summary>
        ValueTask DisposeAsync();
    }
}