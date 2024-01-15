let R = 3;
let C = 3;

const logic = () => {};

const generateMatrix = (R, C) => {
  let matrix = [];

  for (let i = 1; i <= R; i++) {
    let row = [];

    for (let j = 1; j <= C; j++) {
      row.push(logic());
    }

    matrix.push(row);
  }
};
