var li = document.getElementsByTagName('li')
var navigation = document.getElementById('navigation')
var ul = document.getElementById('nav')
var imgDiv = document.getElementById('header')
navigation.style.margin='auto'
navigation.style.width="50px"
ul.style.listStyleType="circle"
imgDiv.style.textAlign='right'
var clone = imgDiv.cloneNode(true)
var createDiv =document.createElement('div')
clone.style.textAlign='left'
var center = document.getElementsByClassName('center')[0]
center.appendChild(createDiv)
createDiv.appendChild(clone)
