let R = 3;
let C = 3;

const logic = (i, j) => (i > j ? 0 : 4 * i - 5 * j + 2);

const generateMatrix = (R, C) => {
  let matrix = [];

  for (let i = 1; i <= R; i++) {
    let row = [];

    for (let j = 1; j <= C; j++) {
      row.push(logic(i, j));
    }

    matrix.push(row);
  }

  return matrix;
};

console.log(JSON.stringify(generateMatrix(R, C), null, 2));
