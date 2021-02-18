CREATE 
VIEW `attendance_statistic` AS
    SELECT 
        `worker`.`w_id` AS `id`,
        `worker`.`w_name` AS `name`,
        YEAR(`attendance`.`att_start_time`) AS `year`,
        MONTH(`attendance`.`att_start_time`) AS `month`,
        SUM((`attendance`.`att_absence` = '迟到')) AS `late_times`,
        SUM((`attendance`.`att_absence` = '早退')) AS `leave_early_times`,
        SUM((`attendance`.`att_absence` = '旷工')) AS `absenteeism_times`,
        SUM((`attendance`.`att_absence` = '正常')) AS `normal_times`
    FROM
        (`worker`
        JOIN `attendance` ON ((`worker`.`w_id` = `attendance`.`w_id`)))
    GROUP BY `worker`.`w_id` , YEAR(`attendance`.`att_start_time`) , MONTH(`attendance`.`att_start_time`)
    ORDER BY `worker`.`w_id` , YEAR(`attendance`.`att_start_time`) , MONTH(`attendance`.`att_start_time`)

CREATE 
VIEW `business_statistic` AS
    SELECT 
        `worker`.`w_id` AS `id`,
        `worker`.`w_name` AS `name`,
        YEAR(`business`.`bus_start_time`) AS `year`,
        MONTH(`business`.`bus_start_time`) AS `month`,
        SUM(`business`.`bus_duration`) AS `total_bus_duration`
    FROM
        (`worker`
        JOIN `business` ON ((`worker`.`w_id` = `business`.`w_id`)))
    GROUP BY `worker`.`w_id` , YEAR(`business`.`bus_start_time`) , MONTH(`business`.`bus_start_time`)
    ORDER BY `worker`.`w_id` , YEAR(`business`.`bus_start_time`) , MONTH(`business`.`bus_start_time`)

CREATE 
VIEW `offwork_statistic` AS
    SELECT 
        `worker`.`w_id` AS `id`,
        `worker`.`w_name` AS `name`,
        YEAR(`offwork`.`off_start_time`) AS `year`,
        MONTH(`offwork`.`off_start_time`) AS `month`,
        SUM(`offwork`.`off_duration`) AS `total_off_duration`
    FROM
        (`worker`
        JOIN `offwork` ON ((`worker`.`w_id` = `offwork`.`w_id`)))
    GROUP BY `worker`.`w_id` , YEAR(`offwork`.`off_start_time`) , MONTH(`offwork`.`off_start_time`)
    ORDER BY `worker`.`w_id` , YEAR(`offwork`.`off_start_time`) , MONTH(`offwork`.`off_start_time`)

CREATE 
VIEW `overtime_statistic` AS
    SELECT 
        `worker`.`w_id` AS `id`,
        `worker`.`w_name` AS `name`,
        YEAR(`overtime`.`over_start_time`) AS `year`,
        MONTH(`overtime`.`over_start_time`) AS `month`,
        SUM(`overtime`.`over_duration`) AS `total_over_duration`
    FROM
        (`worker`
        JOIN `overtime` ON ((`worker`.`w_id` = `overtime`.`w_id`)))
    GROUP BY `worker`.`w_id` , YEAR(`overtime`.`over_start_time`) , MONTH(`overtime`.`over_start_time`)
    ORDER BY YEAR(`overtime`.`over_start_time`) , MONTH(`overtime`.`over_start_time`)




