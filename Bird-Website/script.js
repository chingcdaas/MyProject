function Functionmy() {
  var txt;
  if (confirm("Type of birds are cool right?")) {
    txt = "You pressed OK!";
  } else {
    txt = "You pressed Cancel!";
  }
  document.getElementById("demo").innerHTML = txt;
}


/*----------------------------------------------------------------*/
function myFunction() {
  var x = document.getElementById("myTopnav");
  if (x.className === "topnav") {
    x.className += " responsive";
  } else {
    x.className = "topnav";
  }
}

/*----------------------------------------------------------------*/

