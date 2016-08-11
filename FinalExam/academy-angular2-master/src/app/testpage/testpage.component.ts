import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  moduleId: module.id,
  selector: 'app-testpage',
  templateUrl: 'testpage.component.html',
  styleUrls: ['testpage.component.css']
})
export class TestpageComponent implements OnInit {

  private _router: Router;

  constructor(router: Router) {
     this._router = router;
   }

  ngOnInit() {
  }

  onNavigate(): void {
    this._router.navigateByUrl(`computers`);
  }

}
