import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    { path: '', redirectTo: 'layout', pathMatch: 'prefix' },
    { path: '**', redirectTo: 'layout' },
    {
        path: 'layout',
        loadChildren: () => import('./layout/layout.module').then(m => m.LayoutModule)
    }
];

export const routing = RouterModule.forRoot(routes);
