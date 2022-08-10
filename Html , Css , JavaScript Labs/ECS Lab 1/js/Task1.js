function Box(height, width, length, volume, material, content) {
    this.height = height
    this.width = width
    this.length = length
    this.numOfBooks = content.length
    this.volume = volume
    this.material = material
    this.content = content
}
Box.prototype.toString = function () {
    return `Dimensions ${this.height} , ${this.width} , ${this.length}`
}
Box.prototype.countBooksNum = function () {
    return this.numOfBooks
}
Box.prototype.deleteBook = function (deleteItem) {
    this.content.forEach((item, index) => {
        if (item.title == deleteItem)
            this.content.splice(index, 1)
    })
    return this.content.length
}
Box.prototype.valueOf = function () {
    return this.numOfBooks
}
function Book(title, numofChapters, author,
    numofPages, publisher, numofCopies) {
    this.title = title
    this.numofChapters = numofChapters
    this.author = author
    this.numofPages = numofPages
    this.publisher = publisher
    this.numofCopies = numofCopies
}
var book1 = new Book("lala land", 2, "aya", 2, "a", 50)
var book2 = new Book("sweet love", 2, "ahmed", 2, "b", 100)
var box = new Box(1, 2, 1, 2, 1, "paper", [book1, book2])
var box1 = new Box(1, 2, 1, 2, 1, "paper", [book1, book2])
console.log(box.countBooksNum())
console.log(box.deleteBook("lala land"))
console.log(box.toString())
console.log(box + box1)
