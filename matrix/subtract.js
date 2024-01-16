const add = (m1, m2) => {
  let matrix = [];

  for (let i = 0; i < m1.length; i++) {
    let row = [];

    for (let j = 0; j < m1[i].length; j++) {
      row.push(m1[i][j] - m2[i][j]);
    }

    matrix.push(row);
  }

  return matrix;
};

console.log(
  add(
    [
      [3, 5],
      [1, 2],
    ],
    [
      [2, -1],
      [6, 4],
    ]
  )
);
