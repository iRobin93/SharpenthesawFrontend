<template>
    <div class="blacksmith-container">
      <h2>The blacksmith can sharpen your blade for some points</h2>
      <p>Life Points: <strong>${40|0}</strong></p>
      <p>Sharpness: <strong>${s}</strong> / 3</p>

      <div class="meter" style="margin:8px 0 14px"><span v-bind:style="{ width: pct }"></span></div>

      <button class="btn"  :disabled="can ? true : false">
        ${atMax ? 'Max sharpness reached' : `Sharpen the blade — 20 LP`}
      </button>

      <p class="dim" id="smithMsg" style="margin-top:10px">
        ${atMax ? 'You are Super Sharp!' : (can ? '' : 'Not enough Life Points.')}
      </p>
    </div>`;
</template>

<script>
export default {
    data() {
        return {
        s: 1,
        atMax: s >= 3,
        can: true,
        pct: 50
        };
    },
}
</script>