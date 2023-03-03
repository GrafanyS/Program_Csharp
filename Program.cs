using GIT_C.Program.Base.classes;
using GIT_C.Program.Base.classes.CheckinputData;
using GIT_C.Program.Base.classes.ParseDate;
using GIT_C.Program.Base.classes.ui;
using GIT_C.Program.Base.classes.WorkWithFile;

namespace GIT_C.Program
{
    //  класс запуска программы
    public class Program
    {
        public void Main(string[] args)
        {
            // Путь к папке с файлами
            String infoPathFolder = "Program/data/";
            Presenter presenter = new Presenter(new CGetData(),
                                                new CDataParseProcessor(),
                                                new CCheckDataProcessor(new CCheckQuantity(),
                                                                        new CCheckFullName(),
                                                                        new CCheckBirthday(),
                                                                        new CCheckSex()),
                                                new CFileWriter(new CFileCreator(),
                                                                new CFindTheSameFileName(),
                                                        infoPathFolder));
            presenter.run();
        }
    }
}