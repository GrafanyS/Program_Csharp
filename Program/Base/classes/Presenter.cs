using GIT_C.Program.Base.AbstractClasses;
using GIT_C.Program.Base.classes.ui;
using GIT_C.Program.Base.classes.ParseDate;

namespace GIT_C.Program.Base.classes
{

    /**
     * Объединяет в работу пользовательский интерфейс, парсер строки, проверку на валидность элементов строки
     * Пишет в файлы инфо по заданному формату.
     * @param getData - пользовательский интерфейс.
     * @param dataParseProcessor - парсер строки.
     * @param dataProcessor - проверка элементов на валидность
     * @param fileWriter - пишет в файл согласно условию.
     */
    public class Presenter
    {
        private CGetData getData;
        private CDataParseProcessor dataParseProcessor;
        private ACheckDataProcessor dataProcessor;
        private AFileWriter fileWriter;

        public Presenter(CGetData getData,
                     CDataParseProcessor dataParseProcessor,
                     ACheckDataProcessor dataProcessor,
                     AFileWriter fileWriter)
                     {
                        this.getData = getData;
                        this.dataParseProcessor = dataParseProcessor;
                        this.dataProcessor = dataProcessor;
                        this.fileWriter = fileWriter;
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
            System.Console.WriteLine("\nAll checks are OK!!!");
            // Write data to file
            fileWriter.writeToFile(dataParseProcessor.getInfoToWrite());
        }
    }
    
}