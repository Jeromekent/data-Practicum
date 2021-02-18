//新增部门记录
function Add() {
    var newName = document.getElementById('newName').value;

    //判断输入工号和开始时间是否有空
    if (newName == "") {
        alert("名称不得为空！");
        return
    }

    //判断输入的新部门名称是否和已有部门名称相同（待完善）
    if (true) {
    }

    //以上验证都通过，就向服务器发送新增请求
    $.ajax({
        // 1 请求方式 post或者get
        type: "post",
        // 2 请求地址
        url: "Department/Add",
        //3 参数
        data: { DName: newName },
        // 4 回调函数
        success: function (backData) {
            console.log(backData);
            location.assign(location);
            alert("新增成功！");
        }
    });

};

//修改部门记录
function Update(DId) {
    var DName = document.getElementById("DName_" + DId).value;

    //判断开始时间是否为空
    if (DName == "") {
        alert("部门名称不得为空！");
        location.reload();
        return
    }

    //以上验证都通过，就向服务器发出修改请求
    $.ajax({
        // 1 请求方式 post或者get
        type: "post",
        // 2 请求地址
        url: "Department/Update",
        //3 参数
        data: { DId:DId,DName: DName },
        // 4 回调函数
        success: function (backData) {
            console.log(backData);
            location.assign(location);
            alert("修改成功！");
        }
    });
};

//删除部门记录
function Delete(DId) {

    //判断该部门是否有人任职过
    $.ajax({
        // 1 请求方式 post或者get
        type: "get",
        // 2 请求地址
        url: "Department/CheckDelete",
        //3 参数
        data: { DId },
        dataType: 'json',
        // 4 回调函数
        success: function (backData) {
            if (backData !== "null") {
                alert("该部门有员工信息，无法删除!");
                return;
            }
            else {
                //以上验证都通过，就向服务器发出删除请求
                $.ajax({
                    // 1 请求方式 post或者get
                    type: "get",
                    // 2 请求地址
                    url: "Department/Delete",
                    //3 参数
                    data: { DId },
                    // 4 回调函数
                    success: function (backData) {
                        console.log(backData);
                        location.assign(location);
                        alert("删除成功！");
                    }
                });
            }
            
        }
    });
    

    
};