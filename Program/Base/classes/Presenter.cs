using GIT_C.Program.Base.AbstractClasses;
using GIT_C.Program.Base.classes.ui;
using GIT_C.Program.Base.classes.ParseDate;
using GIT_C.Program.Base.classes.CheckinputData;
using GIT_C.Program.Base.classes.WorkWithFile;

namespace GIT_C.Program.Base.classes
{
    
    public class Presenter
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса Presenter
        /// Объединяет в работу пользовательский интерфейс, парсер строки, проверку на валидность элементов строки
        /// Пишет в файлы инфо по заданному формату.
        /// </summary>
        /// <param name="getData ">- пользовательский интерфейс.</param>
        /// <param name="dataParseProcessor"> - парсер строки.</param>
        /// <param name="dataProcessor"> - проверка элементов на валидность</param>
        /// <param name="fileWriter"> - пишет в файл согласно условию.</param>
        /// <returns></returns>

        private CGetData getData{ get; set; }
        private CDataParseProcessor dataParseProcessor{ get; set; }
        private ACheckDataProcessor dataProcessor{ get; set; }
        private AFileWriter fileWriter{ get; set; }
        private CGetData cGetData{ get; set; }
        private CDataParseProcessor cDataParseProcessor{ get; set; }
        private CCheckDataProcessor cCheckDataProcessor{ get; set; }
        private CFileWriter cFileWriter{ get; set; }

        // public Presenter(CGetData getData, CDataParseProcessor dataParseProcessor, ACheckDataProcessor dataProcessor, AFileWriter fileWriter)
        // {
        //     this.getData = getData;
        //     this.dataParseProcessor = dataParseProcessor;
        //     this.dataProcessor = dataProcessor;
        //     this.fileWriter = fileWriter;
        // }

        public Presenter(CGetData cGetData, CDataParseProcessor cDataParseProcessor, CCheckDataProcessor cCheckDataProcessor, CFileWriter cFileWriter)
        {
            this.cGetData = cGetData;
            this.cDataParseProcessor = cDataParseProcessor;
            this.cCheckDataProcessor = cCheckDataProcessor;
            this.cFileWriter = cFileWriter;
        }

        public void run()
        {
            dataParseProcessor.parseData(getData.getData());
            //Check quantity
            dataProcessor.checkQuantity(dataParseProcessor.getDataArray());
            //Check full name
            dataProcessor.checkFullName(dataParseProcessor.getFullName());
            //Check birthday
            dataProcessor.checkBirthday(dataParseProcessor.getBirthday());
            //Check sex
            dataProcessor.checkSex(dataParseProcessor.getSex());
            System.Console.WriteLine("\nВсе проверки в порядке!!!");
            // Write data to file
            fileWriter.writeToFile(dataParseProcessor.getInfoToWrite());
        }
    }
    
}