window.onload = function() {
    let child = JSON.parse(localStorage.getItem("child"));    
    document.querySelector('#kidnamespan').innerHTML = child.name;
    document.querySelector('#teamidspan').innerHTML = child.teamId;
}

function GetPracticeSchedule() { 
    let child = JSON.parse(localStorage.getItem("child"));    
    fetch(`https://localhost:44331/practice/get/${child.teamId}`)
        .then(response => response.json())
        .then(result => {
            document.querySelectorAll('#kid tbody tr').forEach(element => element.remove())
            let table = document.querySelector('#kid tbody');
            for (let p = 0; p < result.length; ++p) {
                let row = table.insertRow(table.rows.length);

                let pnCell = row.insertCell(0);
                pnCell.innerHTML = result[p].practiceId;

                let pCell = row.insertCell(1);
                let time = moment(result[p].time).format('dddd, MMMM D YYYY, h:mm a');
                pCell.innerHTML = time;
            }
        });
}
