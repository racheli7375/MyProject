function get()
{
  fetch(`https://localhost:44341/api/Role`).then(res=>
  {res.json().then(data=>
    {document.getElementById("d1").innerHTML=JSON.stringify(data)})});

    // fetch(`https://localhost:44341/api/Role`).then(res=>
    // {console.log(res)});
    
  
}
function delete1()
{
    var e = document.getElementById("s").value;
// var text = e.options[e.selectedIndex].text;
  fetch(`https://localhost:44341/api/Role/${e}`,{method:'DELETE'}).then(res=>
  {res.json().then(data=>
    {document.getElementById("d1").innerHTML=JSON.stringify(data)})});
    
  
}
function update(){
    var id=document.getElementById("s2").value;
    var role=document.getElementById("inp").value;
    var desc=document.getElementById("inp2").value;
    fetch(`https://localhost:44341/api/Role/${id}/${role}/${desc}`,{method:'PUT'}).then(res=>
    {res.json().then(data=>
      {document.getElementById("d1").innerHTML=JSON.stringify(data)})});
}