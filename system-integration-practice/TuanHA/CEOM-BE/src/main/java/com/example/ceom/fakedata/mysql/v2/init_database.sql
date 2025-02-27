-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET latin1 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Pay Rates`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Pay Rates` (
  `idPay Rates` INT NOT NULL,
  `Pay Rate Name` VARCHAR(40) NOT NULL,
  `Value` DECIMAL NOT NULL,
  `Tax Percentage` DECIMAL NOT NULL,
  `Pay Type` INT NOT NULL,
  `Pay Amount` DECIMAL NOT NULL,
  `PT - Level C` DECIMAL NOT NULL,
  PRIMARY KEY (`idPay Rates`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Employee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Employee` (
  `idEmployee` INT NOT NULL,
  `Employee Number` INT UNSIGNED NOT NULL auto_increment,
  `Last Name` VARCHAR(45) NOT NULL,
  `First Name` VARCHAR(45) NOT NULL,
  `SSN` DECIMAL(10,0) NOT NULL,
  `Pay Rate` VARCHAR(40) NULL,
  `Pay Rates_idPay Rates` INT NOT NULL,
  `Vacation Days` INT NULL,
  `Paid To Date` DECIMAL(2) NULL,
  `Paid Last Year` DECIMAL(2) NULL,
  PRIMARY KEY (`Employee Number`, `Pay Rates_idPay Rates`),
  UNIQUE INDEX `Employee Number_UNIQUE` (`Employee Number` ASC) VISIBLE,
  INDEX `fk_Employee_Pay Rates` (`Pay Rates_idPay Rates` ASC) VISIBLE,
  CONSTRAINT `fk_Employee_Pay Rates`
    FOREIGN KEY (`Pay Rates_idPay Rates`)
    REFERENCES `mydb`.`Pay Rates` (`idPay Rates`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
