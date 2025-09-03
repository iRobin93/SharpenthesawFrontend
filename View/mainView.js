// View/mainView.js

function updateView() {
  let currentView = '';

  switch (model.app.currentPage) {
    case 'target':
      currentView = targetsView();
      break;
    case 'blacksmith':
      currentView = visitBlacksmithView();
      break;
    case 'nextActivites':
      currentView = (typeof nextActivityView === 'function')
        ? nextActivityView()
        : '<p class="dim">No next activity view.</p>';
      break;
    case 'boostme':
      currentView = boostView();
      break;
    default:
      currentView = defaultView();
      break;
  }

  const el = document.getElementById('app');
  if (!el) return;
  el.innerHTML = currentView;

  // signal per-view background
  el.setAttribute('data-view', model.app.currentPage);

  // sync header HUD
  controller.updateHeaderUI();
}
window.updateView = updateView;
