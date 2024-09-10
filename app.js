let video;
let hp;
let poses = [];
let classificador;  // Variável para o classificador
let label = "";  // Variável para armazenar o rótulo previsto

function preload() {
  // Carregar o modelo treinado do Teachable Machine
  const modelURL = 'modelnew/model.json'; // Caminho do modelo que você baixou
  classificador = ml5.imageClassifier(modelURL, modelReady);

}

function setup() {
  createCanvas(640, 480);
  video = createCapture(VIDEO);
  video.size(300, 240);

  // Cria um novo método handPose com uma única detecção
  hp = ml5.handPose(video, modelReady);
  // Isso configura um evento que preenche a variável global "poses"
  // com um array sempre que novas poses são detectadas

  hp.on('pose', function(results) {
    poses = results;
     console.log(poses)
  });
  // Oculta o elemento de vídeo e exibe apenas a tela (canvas)
  video.hide();
}

function modelReady() {
  select('#status').html('Carregado');
  hp.singlePose();
}

function draw() {
  image(video, 0, 0, width, height);

  // Podemos chamar ambas as funções para desenhar todos os pontos-chave e os esqueletos

  drawKeypoints();
  drawSkeleton();

}

// Função para desenhar elipses sobre os pontos-chave detectados
function drawKeypoints() {
  // Loop por todas as poses detectadas
  for (let i = 0; i < poses.length; i++) {
    // Para cada pose detectada, loop por todos os pontos-chave
    let pose = poses[i];
    for (let j = 0; j < pose.landmarks.length; j++) {
      // Um ponto-chave é um objeto que descreve uma parte do corpo (como o braço direito ou o ombro esquerdo)
      let keypoint = pose.landmarks[j];
      // Desenha uma elipse apenas se a probabilidade do ponto-chave for maior que 0.2
      fill(255, 0, 0);
      noStroke();
      ellipse(keypoint[0], keypoint[1], 10, 10);
    }
  }
}
// Função para desenhar os esqueletos
function drawSkeleton() {
  // Loop por todos os esqueletos detectados
  for (let i = 0; i < poses.length; i++) {
    let annotations = poses[i].annotations;
    // Para cada esqueleto, loop por todas as conexões do corpo
    stroke(255, 0, 0);
    for (let j = 0; j < annotations.thumb.length - 1; j++) {
      // let partA = annotations.thumb[j][0];
      // let partB = annotations.thumb[j][1];
      line(annotations.thumb[j][0], annotations.thumb[j][1], annotations.thumb[j + 1][0], annotations.thumb[j + 1][1]);
    }
    for (let j = 0; j < annotations.indexFinger.length - 1; j++) {
      line(annotations.indexFinger[j][0], annotations.indexFinger[j][1], annotations.indexFinger[j + 1][0], annotations.indexFinger[j + 1][1]);
    }
    for (let j = 0; j < annotations.middleFinger.length - 1; j++) {
      line(annotations.middleFinger[j][0], annotations.middleFinger[j][1], annotations.middleFinger[j + 1][0], annotations.middleFinger[j + 1][1]);
    }
    for (let j = 0; j < annotations.ringFinger.length - 1; j++) {
      line(annotations.ringFinger[j][0], annotations.ringFinger[j][1], annotations.ringFinger[j + 1][0], annotations.ringFinger[j + 1][1]);
    }
    for (let j = 0; j < annotations.pinky.length - 1; j++) {
      line(annotations.pinky[j][0], annotations.pinky[j][1], annotations.pinky[j + 1][0], annotations.pinky[j + 1][1]);
    }

    line(annotations.palmBase[0][0], annotations.palmBase[0][1], annotations.thumb[0][0], annotations.thumb[0][1]);
    line(annotations.palmBase[0][0], annotations.palmBase[0][1], annotations.indexFinger[0][0], annotations.indexFinger[0][1]);
    line(annotations.palmBase[0][0], annotations.palmBase[0][1], annotations.middleFinger[0][0], annotations.middleFinger[0][1]);
    line(annotations.palmBase[0][0], annotations.palmBase[0][1], annotations.ringFinger[0][0], annotations.ringFinger[0][1]);
    line(annotations.palmBase[0][0], annotations.palmBase[0][1], annotations.pinky[0][0], annotations.pinky[0][1]);   
  }
}