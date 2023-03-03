using GIT_C.Program.Base.AbstractClasses;
using GIT_C.Program.Base.classes.ui;
using GIT_C.Program.Base.classes.ParseDate;
using GIT_C.Program.Base.classes.CheckinputData;
using GIT_C.Program.Base.classes.WorkWithFile;

namespace GIT_C.Program.Base.classes
{
    
    public class Presenter
    {
        /**
     * Объединяет в работу пользовательский интерфейс, парсер строки, проверку на валидность элементов строки
     * Пишет в файлы инфо по заданному формату.
     * @param getData - пользовательский интерфейс.
     * @param dataParseProcessor - парсер строки.
     * @param dataProcessor - проверка элементов на валидность
     * @param fileWriter - пишет в файл согласно условию.
     */
        private CGetData getData;
        private CDataParseProcessor dataParseProcessor;
        private ACheckDataProcessor dataProcessor;
        private AFileWriter fileWriter;
        private CGetData cGetData;
        private CDataParseProcessor cDataParseProcessor;
        private CCheckDataProcessor cCheckDataProcessor;
        private CFileWriter cFileWriter;

        public Presenter(CGetData getData, CDataParseProcessor dataParseProcessor, ACheckDataProcessor dataProcessor, AFileWriter fileWriter)
        {
            this.getData = getData;
            this.dataParseProcessor = dataParseProcessor;
            this.dataProcessor = dataProcessor;
            this.fileWriter = fileWriter;
        }

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