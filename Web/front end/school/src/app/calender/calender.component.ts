import { Component, ChangeDetectionStrategy } from '@angular/core';
import { CalendarEvent, CalendarView } from 'angular-calendar';

@Component({
  selector: 'calender',
  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './calender.component.html',
  styleUrls: ['./calender.component.scss']
})
export class CalenderComponent {
  view: CalendarView = CalendarView.Month;

  viewDate: Date = new Date();

  events: CalendarEvent[] = [
    {
      title: 'Editable event',

      start: new Date(),
      actions: [
        {
          label: '<i class="fas fa-fw fa-pencil-alt"></i>',
          onClick: ({ event }: { event: CalendarEvent }): void => {
            console.log('Edit event', event);
          },
        },
      ],
    },
    {
      title: 'Deletable event',

      start: new Date(),
      actions: [
        {
          label: '<i class="fas fa-fw fa-trash-alt"></i>',
          onClick: ({ event }: { event: CalendarEvent }): void => {
            this.events = this.events.filter((iEvent) => iEvent !== event);
            console.log('Event deleted', event);
          },
        },
      ],
    },
    {
      title: 'Non editable and deletable event',
      start: new Date(),
    },
  ];
}
