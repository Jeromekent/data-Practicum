//新增出差记录
function Add() {
    var WId = document.getElementById('newWId').value;
    var StartTime = document.getElementById('newStartTime').value;
    var EndTime = document.getElementById('newEndTime').value;
    var Duration = document.getElementById('newDuration').value;

    //判断输入工号和开始时间是否有空
    if (WId == "" || StartTime == "") {
        alert("工号和开始时间不得为空！");
        return
    }

    /*判断输入的工号是否存在（待完善）
      也可以把html中的“输入工号”，改成“从下拉单中选取工号”。从而省去这里的验证*/
    if (true) {
    }

    //判断输入的开始时间是否满足“yyyy - mm - dd”或“yyyy - mm - dd hh - mm - ss”格式（待完善）
    if (true) {
    }

    //如果结束时间非空，判断结束时间是否满足“yyyy - mm - dd”或“yyyy - mm - dd hh - mm - ss”格式（待完善）
    if (true) {
    }

    //以上验证都通过，就向服务器发送新增请求
    $.ajax({
        // 1 请求方式 post或者get
        type: "post",
        // 2 请求地址
        url: "Business/Add",
        //3 参数
        data: { WId: WId, BusStartTime: StartTime, BusEndTime: EndTime, BusDuration: Duration },
        // 4 回调函数
        success: function (backData) {
            console.log(backData);
            location.assign(location);
            alert("新增成功！");
        }
    });

};

//修改出差记录
function Update(BusNum) {
    var StartTime = document.getElementById("StartTime_" + BusNum).value;
    var EndTime = document.getElementById("EndTime_" + BusNum).value;
    var Duration = document.getElementById("Duration_" + BusNum).value;

    //判断开始时间是否为空
    if (StartTime == "") {
        alert("开始时间不得为空！");
        location.reload();
        return
    }

    //判断输入开始时间是否满足“yyyy-mm-dd”或“yyyy-mm-dd hh-mm-ss”（待完善）
    if (true) {
    }

    //如果结束时间非空，判断结束时间是否满足“yyyy - mm - dd”或“yyyy - mm - dd hh - mm - ss”格式（待完善）
    if (true) {
    }

    //以上验证都通过，就向服务器发出修改请求
    $.ajax({
        // 1 请求方式 post或者get
        type: "post",
        // 2 请求地址
        url: "Business/Update",
        //3 参数
        data: { BusNum: BusNum, BusStartTime: StartTime, BusEndTime: EndTime, BusDuration: Duration },
        // 4 回调函数
        success: function (backData) {
            console.log(backData);
            location.assign(location);
            alert("修改成功！");
        }
    });
};

//删除出差记录
function Delete(BusNum) {
    $.ajax({
        // 1 请求方式 post或者get
        type: "get",
        // 2 请求地址
        url: "Business/Delete",
        //3 参数
        data: { BusNum },
        // 4 回调函数
        success: function (backData) {
            console.log(backData);
            location.assign(location);
            alert("删除成功！");
        }
    });
};

//模糊组合查询
function Query() {
    var Id = document.getElementById('Query_Id').value;
    var Name = document.getElementById('Query_Name').value;
    var Table = document.getElementById("Query_tbody"); //取得自定义的表对象

    //清空页面
    document.getElementById("Query_Id").value = "";
    document.getElementById("Query_Name").value = "";
    var rowNum = Table.rows.length;
    for (i = 0; i < rowNum; i++) {
        Table.deleteRow(i);
        rowNum = rowNum - 1;
        i = i - 1;
    }

    //向服务器发起申请
    $.ajax({
        // 1 请求方式 post或者get
        type: "get",
        // 2 设置后台传回数据的格式
        dataType: 'json',
        // 3 请求地址
        url: "/Business/Query",
        // 4 参数
        data: { Id: Id, Name: Name },

        // 5 回调函数
        success: function (list) {
            if (list != null) {//如果查询到了
            
                for (i = 0; i < list.length; i++) {               
                    row = Table.insertRow(-1); //添加行
                    row.insertCell(0).innerHTML = "<td>" + i + "</td>";
                    row.insertCell(1).innerHTML = "<td>" + list[i].busNum + "</td>";
                    row.insertCell(2).innerHTML = "<td>" + list[i].wId + "</td>";
                    row.insertCell(3).innerHTML = "<td>" + list[i].wName + "</td>";
                    row.insertCell(4).innerHTML = "<td>" + list[i].busStartTime + "</td>";
                    row.insertCell(5).innerHTML = "<td>" + list[i].busEndTime + "</td>";
                    row.insertCell(6).innerHTML = "<td>" + list[i].busDuration + "</td>";
                }       
            }
            else
                alert("查询无结果！");
        },
        error: function () {
            alert("查询出错！");
        }
    });

};