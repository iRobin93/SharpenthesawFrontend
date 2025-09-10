<template>
    <div class="targets-container">
      <h2>When done with your task, click the button and get your points!</h2>
      <div v-html="Button()"></div>
     
      <p class="dim" style="margin-top:10px">
        Each target awards <strong>+{{ LifePointPerTarget }} LP</strong> (LP capped at {{ LifePointsMax }}; overflow becomes Whetstones).
      </p>
    </div>
</template>

<script>
export default {
    data() {
        return {
          LifePointPerTarget: 20,
          LifePointsMax: 60
        };
    },
    created () {
    },
    methods: {
      Button() {
        var Tasks = [
  {
    "Name": "gym",
    "Label": "Went to Gym",
    "Done": true
  },
  {
    "Name": "pomodoro",
    "Label": "Did two hours of Pomodoro",
    "Done": true
  },
  {
    "Name": "lunch",
    "Label": "Finished the lunch without noise!",
    "Done": false
  },
  {
    "Name": "walk",
    "Label": "Went for a walk",
    "Done": false
  },
  {
    "Name": "learned",
    "Label": "Learned something new!",
    "Done": false
  }
];
      var Buttons = "";
      Tasks.forEach(element => {
        Buttons += `<button style="margin-right: 5px;" class="btn target-btn${element.Done ? ' is-done' : ''}"
                    data-id="${element.Name}"
                    ${element.Done ? 'disabled' : ''}
                    onclick="targetsController.handleClick(this)">
              ${element.Label}${element.Done ? ' ✓' : ''}
            </button>`
      });
        return Buttons
      }
    }

}
</script>