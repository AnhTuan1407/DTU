// function showCategory(category) {
//     hideAllContent();
//     document.getElementById(category + 'Content').style.display = 'block';
// }

// function hideAllContent() {
//     var categories = ['loc', 'fp', 'ucp', 'evm', 'dre','home'];
//     categories.forEach(function(category) {
//         document.getElementById(category + 'Content').style.display = 'none';
//     });
// }
function showCategory(category) {
    var homeContent = document.getElementById('homeContent');
    var locContent = document.getElementById('locContent');
    var fpContent = document.getElementById('fpContent');
    var ucpContent = document.getElementById('ucpContent');
    var evmContent = document.getElementById('evmContent');
    var dreContent = document.getElementById('dreContent');

    // Ẩn tất cả các nội dung
    homeContent.style.display = 'none';
    locContent.style.display = 'none';
    fpContent.style.display = 'none';
    ucpContent.style.display = 'none';
    evmContent.style.display = 'none';
    dreContent.style.display = 'none';

    // Hiển thị nội dung tương ứng với category được chọn
    if (category === 'home') {
        homeContent.style.display = 'block';
    } else if (category === 'loc') {
        locContent.style.display = 'block';
        countLines(); // Gọi hàm đếm số dòng code
    } else if (category === 'fp') {
        fpContent.style.display = 'block';
        countFunctionPoint();
    } else if (category === 'ucp') {
        ucpContent.style.display = 'block';
    } else if (category === 'evm') {
        evmContent.style.display = 'block';
    } else if (category === 'dre') {
        dreContent.style.display = 'block';
    }
}


var fileContent = '';
function uploadFile(event) {
    event.preventDefault();
    var inputFile = document.getElementById('inputFile');
    var message = document.getElementById('message');
    var file = inputFile.files[0];
    if (file) {
        var validExtensions = [".c", ".cpp", ".java", ".py", ".js", ".cs", ".php", ".rb", ".swift", ".go", ".R", ".html", ".css"];
        var fileExtension = file.name.split('.').pop();

        if (validExtensions.includes("." + fileExtension)) {
            message.textContent = "File uploaded successfully!";
            message.style.color = "green";
        } else {
            message.textContent = "Invalid file extension. Please select a valid file.";
            message.style.color = "red";
        }
    } else {
        message.textContent = "Please select a file.";
        message.style.color = "red";
    }
}


function drawBarChart(locCount, llocCount, commentCount) {
    var ctx = document.createElement('canvas');
    document.getElementById('locContent').appendChild(ctx);

    var myChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: ['LOC', 'LLOC', 'Comment Lines'],
            datasets: [{
                label: 'Line Of Code',
                data: [locCount, llocCount, commentCount],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(255, 206, 86, 0.2)'
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
}



function countLines() {
    var inputFile = document.getElementById('inputFile');
    var locContent = document.getElementById('locContent');
    var locResult = document.getElementById('locResult_LOC');
    var llocResult = document.getElementById('locResult_LLOC');
    var cmtlResult = document.getElementById('locResult_cmtL');

    var file = inputFile.files[0];
    if (file) {
        var reader = new FileReader();

        reader.onload = function (event) {
            fileContent = event.target.result;
            var locCount = (fileContent.match(/[\n]/g) || []).length;
            // var lineCount = (fileContent.match(/[;\n]/g) || []).length ;
            var commentCount = 0;
            var llocCount = 0;
            var lines = fileContent.split('\n');

            lines.forEach(line => {
                if (line.trim().startsWith('//') || line.trim().startsWith('/*')) {
                    commentCount++;
                }
            })

            lines.forEach(line => {
                // Loại bỏ các dòng trống và các dòng chỉ chứa comment
                const trimmedLine = line.trim();
                if (trimmedLine !== '' && !trimmedLine.startsWith('//') || trimmedLine !== '' && !trimmedLine.startsWith('/*')) {
                    llocCount++;
                }
            });
            // locResult.innerHTML  = "Total lines of code: " + lineCount + "<br/>Total comment lines: " + commentCount;
            // locResult.textContent  = "Total lines of code: " + locCount ;
            // cmtlResult.textContent  = "Total comment lines: " + commentCount ;
            // Hiển thị nội dung của phần tử locContent
            locContent.style.display = "block";
            drawBarChart(locCount, llocCount, commentCount);
        };

        reader.readAsText(file);
    } else {
        // Nếu không có file nào được chọn, thông báo lỗi
        locResult.textContent = "Please upload a file before counting lines.";
        locResult.style.color = "red";
    }
}

function countFunctionPoint(){
    var inputFile = document.getElementById('inputFile');
    var fpContent = document.getElementById('fpContent');
    var fpResult = document.getElementById('fpResult');
    var fpMethod = document.getElementById('fpMethod').value;

    var file = inputFile.files[0];
    if (file) {
        var reader = new FileReader();

        reader.onload = function(event) {
            var fileContent = event.target.result;
            var functionPoints;
            if (fpMethod === 'simple') {
                functionPoints = simpleFunctionPointEstimation(fileContent);
            } else if (fpMethod === 'detailed') {
                functionPoints = detailedFunctionPointEstimation(fileContent);
            }

            // Hiển thị kết quả
            fpContent.style.display = 'block';
            document.getElementById('fpResult').textContent = "Function Points: " + functionPoints;
        };

        reader.readAsText(file);
    } else {
        // Nếu không có file nào được chọn, thông báo lỗi
        fpResult.textContent = "Please upload a file before counting lines.";
        fpResult.style.color = "red";
    }
}

function simpleFunctionPointEstimation(fileContent) {
    // Đây là nơi bạn thực hiện tính toán function point từ nội dung file mã nguồn C++
    // Ví dụ:
    var locCount = (fileContent.match(/[\n\r]/g) || []).length; // Số dòng code
    var functionPoints = locCount * 0.05; // Ví dụ ước lượng đơn giản

    return functionPoints + " (simple)";
}

function detailedFunctionPointEstimation(fileContent) {
    // Đây là một ước lượng chi tiết, bạn có thể thực hiện phân tích mã nguồn để tính toán function point một cách chính xác hơn
    // Code của bạn để tính toán function point chi tiết sẽ được đặt ở đây
    // Ví dụ:
    // var functionPoints = ...;
    // Ví dụ ước lượng chi tiết
    var locCount = (fileContent.match(/[\n\r]/g) || []).length; // Số dòng code
    var commentCount = (fileContent.match(/\/\/.*|\/\*[\s\S]*?\*\/|\/\*[\s\S]*?$/gm) || []).length; // Số dòng chứa comment
    var codeLinesCount = locCount - commentCount; // Số dòng code sau khi loại bỏ comment
    var functionPoints = codeLinesCount * 0.01; // Ví dụ ước lượng chi tiết

    return functionPoints + " (detailed)";
}

function displayFunctionPoints(functionPoints) {
    var fpContent = document.getElementById('fpContent');
    var fpResult = document.getElementById('fpResult');
    fpContent.style.display = 'block';
    fpResult.textContent = "Function Points: " + functionPoints;
}
