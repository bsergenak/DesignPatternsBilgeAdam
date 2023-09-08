namespace SingletonPattern.Lab_1
{
    public class SystemManager
    {
        private static SystemManager _systemManager;

        private SystemManager() { } //Buradak amaç bu sınıfın dışarıdan erişilerek örnekleminin alınmasını engellemektir.
        //sınfıın örnekleminin dışarıda alamayacağız çünkü ctor'oı private yaptık, bunun yerine nesneyi sınıfın kendi içerisinde kontrollü bir şekilde custuom bir method yada property üzerinden nesnenin üretimini kontrol altına alarak üretilmesini temin ettik.

        public static SystemManager CreateSingletonObject()
        {
            //Uygulamnın herhangi bir yerinde "SystemManager." diyerek CreateSingletonObject() methodunu çağırabilirim bu method da bana SystemManager sınıfının örneklemini bir şart doğrultusunda yaratır yada var olanı teslim eder.

            if (_systemManager == null) //Eğer _systemManager field'ının içerisi boş ise şart tutar.
            {
                _systemManager = new SystemManager(); //nesne üretilir
            }
            //_systemManager nesnesi zaten dolu ise direk bize onu teslim edecek.
            return _systemManager;//nesne döndürülür.
        }

        public void CreateLog() => System.Console.WriteLine("A log was created..!");
    }
}
