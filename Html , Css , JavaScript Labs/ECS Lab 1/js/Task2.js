export class Shape {
    constructor(x) {
        this.x = x
        this.y = y
    }
    calArea() {
        return this.x * this.y
    }
    toString() {
        return `Area Is ${this.calArea()} , Parameters Is X = ${this.x}, Y = ${this.y} `
    }
}
export class Rectangle extends Shape {
    constructor(x, y) {
        super(x, y)
    }

}
export class Square extends Shape {
    constructor(x, y) {
        super(x, y)
    }
}
export class Circle extends Shape {
    constructor(x) {
        super(x)
    }
    calArea() {
        return 2 * Math.PI * this.x
    }
    toString() {
        return `Area Is ${this.calArea()} , Parameters Is X = ${this.x}`
    }
}
