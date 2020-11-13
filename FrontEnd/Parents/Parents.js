let buttonId = 3;

function GetAllParents() {
    
    fetch('https://localhost:44331/parent/get/')
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#parents tbody tr').forEach(element => element.remove());
        let table = document.querySelector('#parents tbody');

        for(let i = 0; i < result.length; ++i) {            
            let row = table.insertRow(table.rows.length);

            let nameCell = row.insertCell(0);
            nameCell.innerHTML = result[i].name;

            let phoneCell = row.insertCell(1);
            phoneCell.innerHTML = result[i].phoneNumber;

            let emailCell = row.insertCell(2);
            emailCell.innerHTML = result[i].emailAddress;

            let addCell = row.insertCell(3);
            let btn = document.createElement('input');
            btn.type = 'button';
            btn.value = 'Select';
            btn.setAttribute("parentId", result[i].parentId);

            btn.onclick = function GetKid() {
                console.log(buttonId);
                console.log(btn.getAttribute("parentid"));
                fetch(`https://localhost:44331/child/get/${btn.getAttribute("parentId")}`)
                .then(response => response.json())
                .then(result => {
                    document.querySelectorAll('#kids tbody tr').forEach(element => element.remove());
                    let table = document.querySelector('#kids tbody');
                    buttonId = btn.id;

                    for(let i = 0; i < result.length; ++i) {
                        let row = table.insertRow(table.rows.length);

                        row.onclick = function SetKid() {
                            localStorage.setItem("child", JSON.stringify(result[i]));
                        }

                        let kidNameCell = row.insertCell(0);
                        kidNameCell.innerHTML = result[i].name;

                        let kidLinkCell = row.insertCell(1);
                        kidLink = document.createElement("a");
                        kidLink.setAttribute("href", "../Kids/KidDetails.html");
                        kidLink.innerHTML = `Go to ${result[i].name}'s practice schedule`;
                        kidLinkCell.appendChild(kidLink);
                    }
                });
            }   

            addCell.appendChild(btn);
        }
    });
}


function AddParent()
{
    let parent = {};
    parent.Name = document.querySelector('#parentName').value;
    parent.PhoneNumber = document.querySelector('#phoneNumber').value;
    parent.EmailAddress = document.querySelector('#email').value;

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert("New parent added!");
            document.querySelector('#parentName').value = '';
            document.querySelector('#phoneNumber').value = '';
            document.querySelector('#email').value = '';
            GetAllParents();
        }
    };

    xhr.open("Post", 'https://localhost:44331/parent/add/', true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(parent));
}

function GetKids() {
    fetch(`https://localhost:44331/child/get`)
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#kids tbody tr').forEach(element => element.remove())
        let table = document.querySelector('#kids tbody');

        for (let i = 0; i < result.length; ++i) {
            let row = table.insertRow(table.rows.length);
            
            row.onclick = function SetKid() {
                localStorage.setItem("child", JSON.stringify(result[i]));
            }

            let kidNameCell = row.insertCell(0);
            kidNameCell.innerHTML = result[i].name;

            let kidLinkCell = row.insertCell(1);
            kidLink = document.createElement("a");
            kidLink.setAttribute("href", "../Kids/KidDetails.html");
            kidLink.innerHTML = `Go to ${result[i].name}'s practice schedule`;
            kidLinkCell.appendChild(kidLink);
        }
    });
}

function AddKid() {
    let child = {};
    child.Name = document.querySelector('#kidName').value;
    child.TeamId = 3;
    child.ParentId = 3;
    
    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert("New kid added!");
            document.querySelector('#kidName').value = '';
        }
    };

    xhr.open("Post", 'https://localhost:44331/child/add/', true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(child));
}




