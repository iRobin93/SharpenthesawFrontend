<template>
      <header class="header-banner">
    <h1>Sharpen The Saw</h1>

    <div class="status-left">
    <div id="wsBadge" class="badge">0 WS</div>
  </div>

       <div class="status-right">
    <img id="sharpIcon" class="sharp-icon" src="../assets/saw_dull.png" alt="Blade sharpness">
    <div id="sharpMeter" class="sharp-meter" aria-label="Saw sharpness">
      <span id="sharpLabel" class="label">Dull</span>
      <div class="segments">
        <i class="seg" data-th="1"></i>
        <i class="seg" data-th="2"></i>
        <i class="seg" data-th="3"></i>
      </div>
    </div>
    <div id="pointsBadge" class="points-badge">0 LP</div>  
  </div>
</header>

    <div class="controls">
    <button onclick="model.app.currentPage='target'; updateView()">Target</button>
    <button onclick="model.app.currentPage='blacksmith'; updateView()">Visit Blacksmith</button>
    <button onclick="model.app.currentPage='boostme'; updateView()">Need some Boost!</button>
  </div>

   
    <div id="app">
    </div>
</template>