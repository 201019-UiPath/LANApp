function GetKid() {
    fetch('')
        .then(response => response.json())
        .then(result => {
            document.querySelector('#kid tbody tr').forEach(element => element.remove())
            let table = document.querySelectorAll('#kid tbody');
            for (let p = 0; p < result.length; ++p) {
                let row = table.insertRow(table.rows.length);

                let pnCell = row.insertCell(0);
                pnCell.innerHTML = result[p].kidName;

                let pCell = row.insertCell(1);
                pCell.innerHTML = result[p].teamName;

                let eCell = row.insertCell(2);
                eCell.innerHTML = result[p].practice;

                let iCell = row.insertCell(3);
                iCell.innerHTML = result[p].game;
            }
        });
}

function EditKid() {
    let kid = {};
    kid.kidName = document.querySelector('#kidName').value;
    kid.teamName = document.querySelector('#teamName').value;
    kid.practice = document.querySelector('#practice').value;
    kid.game = document.querySelector('#game').value;

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert("Kid edited");
            document.querySelector('#kidName').value = '';
            document.querySelector('#teamName').value = '';
            document.querySelector('#practice').value = '';
            document.querySelector('#game').value = '';
            GetKid();
        }
    };
    xhr.open("Post", 'idk yet', true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(parent));
}
