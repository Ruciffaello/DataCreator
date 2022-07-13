using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class DatabaseScript
    {
        public string createDatabase = "CREATE DATABASE IF NOT EXISTS alacrity;";

        public string createTableCodingTestResult = "CREATE  TABLE IF NOT EXISTS `alacrity`.`coding_test_result` ( " +
            "  `id` INT  AUTO_INCREMENT ," +
            "  `candidate_account` VARCHAR(150) ," +
            "  `candidate_name` VARCHAR(50) ," +
            " `test_date` DATETIME ," +
            " `cost_time` TIME ," +
            " `question_id` INT ," +
            " `mark` INT ," +
            " `submit_file` MEDIUMTEXT ," +
            " PRIMARY KEY (`id`,`candidate_account`) ) " +
            " ENGINE = InnoDB; ";

        public string createTableCodingQuestion = "CREATE  TABLE IF NOT EXISTS `alacrity`.`coding_question` (" +
            "  `id` INT AUTO_INCREMENT ," +
            "  `qestion_id` INT ," +
            "  `qestion_title` NVARCHAR(255) ," +
            "  `qestion_content` MEDIUMTEXT ," +
            "  `create_date` MEDIUMTEXT ," +
            "  PRIMARY KEY (`id`,`qestion_id`) ) " +
            "ENGINE = InnoDB;";

        public string createTableCandidateInformation = "CREATE  TABLE IF NOT EXISTS `alacrity`.`candidate_information` (" +
            "  `id` INT AUTO_INCREMENT ," +
            "  `candidate_account` NVARCHAR(127) ," +
            "  `candidate_password` NVARCHAR(127) ," +
            " `candidate_name` NVARCHAR(127) ," +
            " `phone` NVARCHAR(63) ," +
            " `email` NVARCHAR(127) ," +
            " PRIMARY KEY (`id`,`candidate_account`) )" +
            " ENGINE = InnoDB;" ;

        public string createTableManagerInformation = "CREATE  TABLE IF NOT EXISTS `alacrity`.`manager_information` (" +
            "  `id` INT AUTO_INCREMENT ," +
            "  `manager_account` NVARCHAR(127) ," +
            "  `manager_password` NVARCHAR(127) ," +
            "  `manager_name` NVARCHAR(127) ," +
            " `role` NVARCHAR(63) ," +
            " `email` NVARCHAR(127) ," +
            " PRIMARY KEY (`id`,`manager_account`) )" +
            " ENGINE = InnoDB;";

        public string dropAllTable = "DROP TABLE IF EXISTS alacrity.candidate_information; " +
            "DROP TABLE IF EXISTS alacrity.coding_question; " +
            "DROP TABLE IF EXISTS alacrity.coding_test_result; " +
            "DROP TABLE IF EXISTS alacrity.manager_information; ";

    }

    


}
