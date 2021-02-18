DELIMITER $$

USE `db_test`$$

DROP TRIGGER /*!50032 IF EXISTS */ `insert_w_wage`$$

CREATE
    /*!50017 DEFINER = 'root'@'localhost' */
    TRIGGER `insert_w_wage` BEFORE INSERT ON `worker` 
    FOR EACH ROW BEGIN
	IF (NEW.w_post='管理岗') AND (NEW.w_wage<'10000')  THEN 
		SET NEW.w_wage='10000';  
	ELSEIF (NEW.w_post='普通岗') AND (NEW.w_wage<'6000')  THEN 
		SET NEW.w_wage='6000';
	END IF; 
    END;
$$

DELIMITER ;