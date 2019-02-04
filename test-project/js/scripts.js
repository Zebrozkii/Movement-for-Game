var character=document.getElementById("character");
var container=document.getElementById("container");
var characterLeft=0;
function move(e){
if (e.keyCode===39){
  characterLeft+=2;
  character.style.left=characterLeft+'px';
}
  if(e.keyCode===37){
    characterLeft-=2;
  character.styles.left=characterLeft+'px';
}
}
document.onkeydown=move;
